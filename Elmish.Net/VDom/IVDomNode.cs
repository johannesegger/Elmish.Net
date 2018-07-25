using System;
using System.Collections.Generic;
using LanguageExt;

namespace Elmish.Net.VDom
{
    public delegate (Option<object> Node, ISub<TMessage> Subscriptions) MergeResult<TMessage>(Option<object> o);
    public delegate (Option<T> Node, ISub<TMessage> Subscriptions) MergeResult<TMessage, T>(Option<T> o);

    public interface IVDomNode<TMessage>
    {
        MergeResult<TMessage> MergeWith(Option<IVDomNode<TMessage>> node);
    }

    public interface IVDomNode<out T, TMessage> : IVDomNode<TMessage>
    {
        IReadOnlyCollection<IVDomNodeProperty> Properties { get; }
        IVDomNode<T, TMessage> AddProperty(IVDomNodeProperty<T, TMessage> property);
        IVDomNode<T, TMessage> AddSubscription(Func<T, ISub<TMessage>> subscribe);
    }
}