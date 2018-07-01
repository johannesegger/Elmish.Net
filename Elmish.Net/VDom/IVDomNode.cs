using System;
using System.Collections.Generic;
using LanguageExt;

namespace Elmish.Net.VDom
{
    public delegate (Option<object> Node, IDisposable Subscriptions) MergeResult(Option<object> o);
    public delegate (Option<T> Node, IDisposable Subscriptions) MergeResult<T>(Option<T> o);

    public interface IVDomNode
    {
        MergeResult MergeWith(Option<IVDomNode> node);
    }

    public interface IVDomNode<out T> : IVDomNode
    {
        IReadOnlyCollection<IVDomNodeProperty> Properties { get; }
        IVDomNode<T> AddProperty(IVDomNodeProperty<T> property);
        IVDomNode<T> AddSubscription(Func<T, IDisposable> subscribe);
    }
}