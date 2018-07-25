using System;
using System.Reflection;
using Elmish.Net.Utils;
using static LanguageExt.Prelude;

namespace Elmish.Net.VDom
{
    public class VDomNodeChildNodeProperty<TParent, TMessage, TValue> : IVDomNodeProperty<TParent, TMessage, IVDomNode<TValue, TMessage>>
    {
        private readonly PropertyInfo propertyInfo;

        public VDomNodeChildNodeProperty(
            PropertyInfo propertyInfo,
            IVDomNode<TValue, TMessage> value)
        {
            this.propertyInfo = propertyInfo;
            Value = value;
        }

        public IVDomNode<TValue, TMessage> Value { get; }

        public Func<TParent, ISub<TMessage>> MergeWith(IVDomNodeProperty property)
        {
            return Optional(property)
                .TryCast<IVDomNodeProperty<TParent, TMessage, IVDomNode<TMessage>>>()
                .Some(typedProperty =>
                {
                    var mergeNode = Value.MergeWith(Optional(typedProperty.Value));
                    return new Func<TParent, ISub<TMessage>>(o =>
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
                    return new Func<TParent, ISub<TMessage>>(o =>
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
            return property is VDomNodeChildNodeProperty<TParent, TMessage, TValue> p
                && Equals(propertyInfo, p.propertyInfo);
        }
    }
}