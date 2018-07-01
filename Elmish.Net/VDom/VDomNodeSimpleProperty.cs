using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Reflection;
using Elmish.Net.Utils;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Elmish.Net.VDom
{
    public class VDomNodeSimpleProperty<TParent, TValue> : IVDomNodeProperty<TParent, TValue>
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

        public Func<TParent, IDisposable> MergeWith(IVDomNodeProperty property)
        {
            return Optional(property)
                .TryCast<IVDomNodeProperty<TParent, TValue>>()
                .Bind(p =>
                    equalityComparer.Equals(p.Value, Value)
                    ? Some(Unit.Default)
                    : None
                )
                .Some(_ => new Func<TParent, IDisposable>(o => Disposable.Empty))
                .None(() => new Func<TParent, IDisposable>(o =>
                {
                    propertyInfo.SetValue(o, Value);
                    return Disposable.Empty;
                }));
        }

        public bool CanMergeWith(IVDomNodeProperty property)
        {
            return property is VDomNodeSimpleProperty<TParent, TValue> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}