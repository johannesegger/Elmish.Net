using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Disposables;
using System.Reflection;
using Elmish.Net.Utils;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Elmish.Net.VDom
{
    public class VDomNodeChildNodeCollectionProperty<TParent> : IVDomNodeProperty<TParent, IImmutableList<IVDomNode>>
    {
        private readonly PropertyInfo propertyInfo;

        public VDomNodeChildNodeCollectionProperty(
            PropertyInfo propertyInfo,
            IImmutableList<IVDomNode> value)
        {
            this.propertyInfo = propertyInfo;
            Value = value;
        }

        public IImmutableList<IVDomNode> Value { get; }

        public Func<TParent, IDisposable> MergeWith(IVDomNodeProperty property)
        {
            var listProperty = Optional(property)
                // Use IReadOnlyList<T> instead of IImmutableList<T> because T is covariant for IReadOnlyList
                .TryCast<IVDomNodeProperty<TParent, IReadOnlyList<object>>>(); // can't use IReadOnlyList<IVDomNode<T>> because T is not covariant for IVDomNode

            var items = listProperty
                .Some(oldProperty => oldProperty.Value)
                .None(() => ImmutableList<object>.Empty);

            var replaceActions = Value
                .Take(items.Count)
                .Select((value, i) =>
                {
                    var apply = value.MergeWith(Optional(items[i] as IVDomNode));
                    return new Func<System.Collections.IList, IDisposable>(o =>
                    {
                        var (p, d) = apply(o[i]);
                        p
                            .IfSome(newItem =>
                            {
                                o.RemoveAt(i);
                                o.Insert(i, newItem);
                            });
                        return d;
                    });
                });

            var addActions = Value
                .Skip(items.Count)
                .Select(value =>
                {
                    var apply = value.MergeWith(None);
                    return new Func<System.Collections.IList, IDisposable>(o =>
                    {
                        var (p, d) = apply(None);
                        p
                            .IfSome(newItem => o.Add(newItem));
                        return d;
                    });
                });

            var removeActions = items
                .Skip(Value.Count)
                .Select(_ =>
                {
                    return new Func<System.Collections.IList, IDisposable>(o =>
                    {
                        o.RemoveAt(o.Count - 1);
                        return Disposable.Empty;
                    });
                });

            var actions = replaceActions
                .Concat(removeActions)
                .Concat(addActions)
                .ToList();
            var act = new Func<System.Collections.IList, IDisposable>(o =>
                new CompositeDisposable(actions.Select(a => a(o))));

            return new Func<TParent, IDisposable>(o =>
            {
                return act((System.Collections.IList)propertyInfo.GetValue(o));
            });
        }

        public bool CanMergeWith(IVDomNodeProperty property)
        {
            return property is VDomNodeChildNodeCollectionProperty<TParent> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}