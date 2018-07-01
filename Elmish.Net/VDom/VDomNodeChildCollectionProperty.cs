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
    // TODO merge with VDomNodeChildNodeCollectionProperty<T>?
    public class VDomNodeChildCollectionProperty<TParent, TValue> : IVDomNodeProperty<TParent, IImmutableList<TValue>>
    {
        private readonly PropertyInfo propertyInfo;
        private readonly IEqualityComparer<TValue> equalityComparer;

        public VDomNodeChildCollectionProperty(
            PropertyInfo propertyInfo,
            IImmutableList<TValue> value,
            IEqualityComparer<TValue> equalityComparer)
        {
            this.propertyInfo = propertyInfo;
            Value = value;
            this.equalityComparer = equalityComparer;
        }

        public IImmutableList<TValue> Value { get; }

        public Func<TParent, IDisposable> MergeWith(IVDomNodeProperty property)
        {
            var items = Optional(property)
                // Use IReadOnlyList<T> instead of IImmutableList<T> because T is covariant for IReadOnlyList
                .TryCast<IVDomNodeProperty<TParent, IReadOnlyList<object>>>()
                .Some(oldProperty => oldProperty.Value)
                .None(() => ImmutableList<object>.Empty);

            var replaceActions = Value
                .Take(items.Count)
                .Select((value, i) =>
                {
                    if (items[i] is TValue item && equalityComparer.Equals(value, item))
                    {
                        return None;
                    }
                    else
                    {
                        return Some(new Action<System.Collections.IList>(o => o[i] = value));
                    }
                })
                .Choose(p => p);

            var addActions = Value
                .Skip(items.Count)
                .Select(value =>
                {
                    return new Action<System.Collections.IList>(o => o.Add(value));
                });

            var removeActions = items
                .Skip(Value.Count)
                .Select(_ =>
                {
                    return new Action<System.Collections.IList>(o =>
                    {
                        o.RemoveAt(o.Count - 1);
                    });
                });

            var actions = replaceActions
                .Concat(removeActions)
                .Concat(addActions)
                .ToList();
            var act = new Action<System.Collections.IList>(o => actions.ForEach(a => a(o)));
            return new Func<TParent, IDisposable>(o =>
            {
                act((System.Collections.IList)propertyInfo.GetValue(o));
                return Disposable.Empty;
            });
        }

        public bool CanMergeWith(IVDomNodeProperty property)
        {
            return property is VDomNodeChildCollectionProperty<TParent, TValue> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}