using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
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
            Func<TState, Dispatch<TMessage>, IVDomNode<TViewNode, TMessage>> view,
            Func<TState, Sub<TMessage>> subscriptions,
            IScheduler dispatcherScheduler,
            Expression<Func<TViewNode>> rootNode)
        {
            var messageSubject = new Subject<TMessage>();
            Dispatch<TMessage> dispatch = v => messageSubject.OnNext(v);

            var getter = rootNode.Compile();
            var setter = rootNode.CreateSetter();

            var d = new CompositeDisposable();

            var obs = messageSubject
                .Synchronize()
                .Scan(init, (updateResult, message) => update(message, updateResult.State))
                .StartWith(init)
                .Publish();

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
                        subscriptionDisposable.Disposable = b[1].Subscribe(dispatcherScheduler, dispatch);
                    }
                })
                .DisposeWith(d);

            // Merge current VDom with base VDom
            // On requestAnimationFrame use latest merger and set VDom as base VDom
            IVDomNode<TMessage> lastDom = null;
            IVDomNode<TViewNode, TMessage> currentDom = null;
            MergeResult<TMessage> currentMerge = null;
            var gate = new object();
            var mergeResults = obs
                .Select(updateResult => updateResult.State)
                .SkipIntermediate(
                    state =>
                    {
                        var dom = view(state, dispatch);
                        lock(gate)
                        {
                            currentDom = dom;
                            currentMerge = dom.MergeWith(Optional(lastDom));
                            return Unit.Default;
                        }
                    })
                .Subscribe()
                .DisposeWith(d);

            var viewSubscriptionsDisposable = new SerialDisposable()
                .DisposeWith(d);

            requestAnimationFrame
                .Select(_ =>
                {
                    lock(gate)
                    {
                        lastDom = currentDom;
                        return currentMerge;
                    }
                })
                .DistinctUntilChanged()
                .Where(merge => merge != null)
                .ObserveOn(dispatcherScheduler)
                .Subscribe(merge =>
                {
                    var oldNode = getter();
                    viewSubscriptionsDisposable.Disposable = Disposable.Empty;
                    var (newNode, subscription) = merge(oldNode);
                    viewSubscriptionsDisposable.Disposable = subscription.Subscribe(dispatcherScheduler, dispatch); // TODO fix merging subscriptions
                    newNode.TryCast<TViewNode>().IfSome(setter);
                })
                .DisposeWith(d);

            obs.Connect().DisposeWith(d);
        }

        public static void Run<TState, TMessage, TViewNode>(
            IObservable<Unit> requestAnimationFrame,
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVDomNode<TViewNode, TMessage>> view,
            IScheduler dispatcherScheduler,
            Expression<Func<TViewNode>> rootNode)
        {
            Run(
                requestAnimationFrame,
                init,
                update,
                view,
                _ => Sub.None<TMessage>(),
                dispatcherScheduler,
                rootNode);
        }
    }
}
