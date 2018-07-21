using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Elmish.Net.Utils;
using Elmish.Net.VDom;
using LanguageExt;
using static LanguageExt.Prelude;
using Unit = System.Reactive.Unit;

namespace Elmish.Net
{
    public static class ElmishApp
    {
        public static void Run<TState, TMessage, TViewNode>(
            IObservable<Unit> requestAnimationFrame,
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVDomNode<TViewNode>> view,
            Func<TState, Sub<TMessage>> subscriptions,
            IScheduler workerScheduler,
            IScheduler dispatcherScheduler,
            Expression<Func<TViewNode>> rootNode)
        {
            var messageSubject = new Subject<TMessage>();
            Dispatch<TMessage> dispatch = v => dispatcherScheduler.Schedule(() => messageSubject.OnNext(v));

            var getter = rootNode.Compile();
            var setter = rootNode.CreateSetter();

            var d = new CompositeDisposable();

            var viewSubscriptionsDisposable = new SerialDisposable()
                .DisposeWith(d);

            var initSubject = new Subject<(TState State, Cmd<TMessage> Cmd)>();

            var obs = messageSubject
                //.ObserveOn(workerScheduler)
                .Scan(init, (updateResult, message) => update(message, updateResult.State))
                .Merge(initSubject/*.ObserveOn(workerScheduler)*/)
                .Publish()
                .RefCount();

            obs
                .Subscribe(updateResult => updateResult.Cmd.Execute(dispatch))
                .DisposeWith(d);

            var subscriptionDisposable = new SerialDisposable().DisposeWith(d);
            obs
                .Select(updateResult => subscriptions(updateResult.State))
                .StartWith(Sub.None<TMessage>())
                .Buffer(2, 1)
                .Subscribe(b =>
                {
                    if (!Equals(b[0].Key, b[1].Key))
                    {
                        subscriptionDisposable.Disposable = Disposable.Empty;
                        subscriptionDisposable.Disposable = b[1].Subscribe(dispatch);
                    }
                })
                .DisposeWith(d);

            // TODO merge with base vdom
            // on requestAnimationFrame use latest merger and set vdom as base vdom

            var mergeResults = obs
                .Select(updateResult => view(updateResult.State, dispatch))
                .Sample(requestAnimationFrame)
                .StartWith((IVDomNode)null)
                .Buffer(2, 1)
                .Select(b => b[1].MergeWith(Optional(b[0])));

            mergeResults
                .ObserveOn(dispatcherScheduler)
                .Subscribe(merge =>
                {
                    var oldNode = getter();
                    viewSubscriptionsDisposable.Disposable = Disposable.Empty;
                    var (newNode, subscription) = merge(oldNode);
                    viewSubscriptionsDisposable.Disposable = subscription;
                    newNode.TryCast<TViewNode>().IfSome(setter);
                })
                .DisposeWith(d);

            // Wait before publishing the first item until the subscription is fully set up .
            // If we didn't wait until here and instead used `.StartWith(init)`
            // the subscriber would get called before the subscription to `messageSubject`
            // is fully set up and calls to `dispatchSubject.OnNext` might get lost.
            initSubject.OnNext(init);
            initSubject.OnCompleted();
        }

        public static void Run<TState, TMessage, TViewNode>(
            IObservable<Unit> requestAnimationFrame,
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVDomNode<TViewNode>> view,
            IScheduler workerScheduler,
            IScheduler dispatcherScheduler,
            Expression<Func<TViewNode>> rootNode)
        {
            Run(
                requestAnimationFrame,
                init,
                update,
                view,
                _ => Sub.None<TMessage>(),
                workerScheduler,
                dispatcherScheduler,
                rootNode);
        }
    }
}
