using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Disposables;

namespace Elmish.Net
{
    [Equals]
    public class Sub<TMessage>
    {
        private readonly Func<Dispatch<TMessage>, IDisposable> subscribe;

        public Sub(object key, Func<Dispatch<TMessage>, IDisposable> subscribe)
        {
            Key = key;
            this.subscribe = subscribe;
        }

        public object Key { get; }

        public IDisposable Subscribe(Dispatch<TMessage> dispatch)
        {
            return this.subscribe(dispatch);
        }
    }

    public static class Sub
    {
        public static Sub<TMessage> None<TMessage>()
        {
            return new Sub<TMessage>(null, _ => Disposable.Empty);
        }

        public static Sub<TMessage> Batch<TMessage>(IReadOnlyCollection<Sub<TMessage>> subs)
        {
            return new Sub<TMessage>(
                subs.Select(s => s.Key),
                dispatch => new CompositeDisposable(subs.Select(s => s.Subscribe(dispatch))));
        }

        public static Sub<TMessage> Batch<TMessage>(params Sub<TMessage>[] subs)
        {
            return Batch((IReadOnlyCollection<Sub<TMessage>>)subs);
        }

        public static Sub<TMessage> Create<TMessage, TKey>(TKey key, Func<TKey, Dispatch<TMessage>, IDisposable> subscribe)
        {
            return new Sub<TMessage>(key, dispatch => subscribe(key, dispatch));
        }
    }
}
