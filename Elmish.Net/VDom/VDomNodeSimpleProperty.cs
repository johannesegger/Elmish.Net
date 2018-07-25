using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reflection;
using Elmish.Net.Utils;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Elmish.Net.VDom
{
    public class VDomNodeSimpleProperty<TParent, TMessage, TValue> : IVDomNodeProperty<TParent, TMessage, TValue>
    {
        private readonly PropertyInfo propertyInfo;
        private readonly IEqualityComparer<TValue> equalityComparer;

        public VDomNodeSimpleProperty(PropertyInfo propertyInfo, TValue value, IEqualityComparer<TValue> equalityComparer)
        {
            this.propertyInfo = propertyInfo;
            Value = value;
            this.equalityComparer = equalityComparer;
        }

        public TValue Value { get; }

        public Func<TParent, ISub<TMessage>> MergeWith(IVDomNodeProperty property)
        {
            return Optional(property)
                .TryCast<IVDomNodeProperty<TParent, TMessage, TValue>>()
                .Bind(p =>
                    equalityComparer.Equals(p.Value, Value)
                    ? Some(Unit.Default)
                    : None
                )
                .Some(_ => new Func<TParent, ISub<TMessage>>(o => Sub.None<TMessage>()))
                .None(() => new Func<TParent, ISub<TMessage>>(o =>
                {
                    propertyInfo.SetValue(o, Value);
                    return Sub.None<TMessage>();
                }));
        }

        public bool CanMergeWith(IVDomNodeProperty property)
        {
            return property is VDomNodeSimpleProperty<TParent, TMessage, TValue> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}