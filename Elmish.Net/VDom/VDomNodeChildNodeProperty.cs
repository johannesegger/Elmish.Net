using System;
using System.Reflection;
using Elmish.Net.Utils;
using static LanguageExt.Prelude;

namespace Elmish.Net.VDom
{
    public class VDomNodeChildNodeProperty<TParent, TValue> : IVDomNodeProperty<TParent, IVDomNode<TValue>>
    {
        private readonly PropertyInfo propertyInfo;

        public VDomNodeChildNodeProperty(
            PropertyInfo propertyInfo,
            IVDomNode<TValue> value)
        {
            this.propertyInfo = propertyInfo;
            Value = value;
        }

        public IVDomNode<TValue> Value { get; }

        public Func<TParent, IDisposable> MergeWith(IVDomNodeProperty property)
        {
            return Optional(property)
                .TryCast<IVDomNodeProperty<TParent, IVDomNode>>()
                .Some(typedProperty =>
                {
                    var mergeNode = Value.MergeWith(Optional(typedProperty.Value));
                    return new Func<TParent, IDisposable>(o =>
                    {
                        var (p, d) = mergeNode(propertyInfo.GetValue(o));
                        p
                            .IfSome(v => propertyInfo.SetValue(o, v));
                        return d;
                    });
                })
                .None(() =>
                {
                    var mergeNode = Value.MergeWith(None);
                    return new Func<TParent, IDisposable>(o =>
                    {
                        var (p, d) = mergeNode(None);
                        p
                            .IfSome(v => propertyInfo.SetValue(o, v));
                        return d;
                    });
                });
        }

        public bool CanMergeWith(IVDomNodeProperty property)
        {
            var propertyName = propertyInfo.Name;
            return property is VDomNodeChildNodeProperty<TParent, TValue> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}