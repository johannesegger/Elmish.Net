using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using static LanguageExt.Prelude;

namespace Elmish.Net
{
    public static class ElmishApp
    {
        public static void Run<TState, TMessage, TViewNode>(
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVNode<TViewNode>> view,
            IScheduler dispatcherScheduler,
            Expression<Func<TViewNode>> rootNode)
        {
            var messageSubject = new Subject<IObservable<TMessage>>();

            var getter = rootNode.Compile();
            var setter = rootNode.CreateSetter();

            var viewSubscriptionsDisposable = new SerialDisposable();
            var commandDisposable = new SerialDisposable();

            var initSubject = new Subject<(TState State, Cmd<TMessage> Cmd)>();

            var obs = messageSubject
                .Switch()
                .Scan(init, (updateResult, message) => update(message, updateResult.State))
                .Merge(initSubject)
                .ObserveOn(dispatcherScheduler)
                .Subscribe(updateResult =>
                {
                    var dispatchSubject = new Subject<TMessage>();
                    messageSubject.OnNext(dispatchSubject);

                    // TODO find a way to unify cancellation of
                    // * subscription to dispatchSubject (canceled with `Switch` at the top of the statement)
                    // * View subscriptions
                    // * Cancellation token for command execution

                    Dispatch<TMessage> dispatch = dispatchSubject.OnNext;
                    var viewResult = view(updateResult.State, dispatch);

                    var oldContent = getter();
                    var newContent = viewResult.Materialize(Optional(oldContent));
                    viewSubscriptionsDisposable.Disposable = newContent;
                    if (!ReferenceEquals(oldContent, newContent.Resource))
                    {
                        setter(newContent.Resource);
                    }

                    var cancellationDisposable = new CancellationDisposable();
                    commandDisposable.Disposable = cancellationDisposable;
                    updateResult.Cmd.Subs.ForEach(sub => sub(dispatch, cancellationDisposable.Token));
                });

            // Wait for the first item to be published until the subscription is fully set up.
            // If we didn't wait here and instead used `.StartWith(init)`
            // the subscriber would get called before the subscription to `messageSubject`
            // is fully set up and calls to `dispatchSubject.OnNext` might get lost.
            initSubject.OnNext(init);
        }
    }
}
