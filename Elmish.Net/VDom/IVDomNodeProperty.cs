using System;

namespace Elmish.Net.VDom
{
    public interface IVDomNodeProperty
    {
    }

    public interface IVDomNodeProperty<in TParent> : IVDomNodeProperty
    {
        bool CanMergeWith(IVDomNodeProperty property);
        Func<TParent, IDisposable> MergeWith(IVDomNodeProperty property);
    }

    public interface IVDomNodeProperty<TParent, out TValue> : IVDomNodeProperty<TParent>
    {
        TValue Value { get; }
    }
}