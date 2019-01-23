using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace Elmish.Net
{
    public interface ISub<out TMessage>
    {
        object Key { get; }
        IDisposable Subscribe(Dispatch<TMessage> dispatch);
    }

    [Equals]
    public class Sub<TMessage> : ISub<TMessage>
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
            return new Sub<TMessage>(null, dispatch => Disposable.Empty);
        }

        public static Sub<TMessage> Batch<TMessage>(IReadOnlyCollection<ISub<TMessage>> subs)
        {
            return new Sub<TMessage>(
                subs.Select(s => s.Key),
                dispatch => new CompositeDisposable(subs.Select(s => s.Subscribe(dispatch))));
        }

        public static Sub<TMessage> Batch<TMessage>(IEnumerable<ISub<TMessage>> subs)
        {
            return Batch(subs.ToList());
        }

        public static Sub<TMessage> Batch<TMessage>(params ISub<TMessage>[] subs)
        {
            return Batch((IReadOnlyCollection<ISub<TMessage>>)subs);
        }

        public static Sub<TMessage> Create<TMessage, TKey>(TKey key, Func<TKey, IObservable<TMessage>> observableFactory)
        {
            return new Sub<TMessage>(
                key,
                dispatch => observableFactory(key)
                    .Subscribe(p => dispatch(p)));
        }
    }
}
