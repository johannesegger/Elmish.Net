using System;

namespace Elmish.Net.VDom
{
    public interface IVDomNodeProperty
    {
    }

    public interface IVDomNodeProperty<in TParent, out TMessage> : IVDomNodeProperty
    {
        bool CanMergeWith(IVDomNodeProperty property);
        Func<TParent, ISub<TMessage>> MergeWith(IVDomNodeProperty property);
    }

    public interface IVDomNodeProperty<in TParent, out TMessage, out TValue> : IVDomNodeProperty<TParent, TMessage>
    {
        TValue Value { get; }
    }
}