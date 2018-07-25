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
    public class VDomNodeChildSequenceProperty<TParent, TMessage, TValue> : IVDomNodeProperty<TParent, TMessage, IImmutableList<TValue>>
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
        
        public Func<TParent, ISub<TMessage>> MergeWith(IVDomNodeProperty property)
        {
            var items = Optional(property)
                // Use IReadOnlyList<T> instead of IImmutableList<T> because T is covariant for IReadOnlyList
                .TryCast<IVDomNodeProperty<TParent, TMessage, IReadOnlyList<TValue>>>()
                .Some(oldProperty => oldProperty.Value)
                .None(() => ImmutableList<TValue>.Empty);

            if (items.SequenceEqual(Value, equalityComparer))
            {
                return new Func<TParent, ISub<TMessage>>(_ => Sub.None<TMessage>());
            }
            else
            {
                return new Func<TParent, ISub<TMessage>>(o =>
                {
                    propertyInfo.SetValue(o, Value);
                    return Sub.None<TMessage>();
                });
            }
        }

        public bool CanMergeWith(IVDomNodeProperty property)
        {
            return property is VDomNodeChildSequenceProperty<TParent, TMessage, TValue> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}