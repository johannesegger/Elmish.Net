using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Disposables;
using System.Reflection;
using Elmish.Net.Utils;
using static LanguageExt.Prelude;

namespace Elmish.Net.VDom
{
    public class VDomNodeChildSequenceProperty<TParent, TValue> : IVDomNodeProperty<TParent, IImmutableList<TValue>>
    {
        private readonly PropertyInfo propertyInfo;
        private readonly IEqualityComparer<TValue> equalityComparer;

        public VDomNodeChildSequenceProperty(
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
                .TryCast<IVDomNodeProperty<TParent, IReadOnlyList<TValue>>>()
                .Some(oldProperty => oldProperty.Value)
                .None(() => ImmutableList<TValue>.Empty);

            if (items.SequenceEqual(Value, equalityComparer))
            {
                return new Func<TParent, IDisposable>(_ => Disposable.Empty);
            }
            else
            {
                return new Func<TParent, IDisposable>(o =>
                {
                    propertyInfo.SetValue(o, Value);
                    return Disposable.Empty;
                });
            }
        }

        public bool CanMergeWith(IVDomNodeProperty property)
        {
            return property is VDomNodeChildSequenceProperty<TParent, TValue> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}