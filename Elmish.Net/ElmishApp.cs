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
            var messageSubject = new Subject<TMessage>();
            Dispatch<TMessage> dispatch = messageSubject.OnNext;

            var getter = rootNode.Compile();
            var setter = rootNode.CreateSetter();

            var viewSubscriptionsDisposable = new SerialDisposable();
            messageSubject
                .Scan(init, (updateResult, message) => update(message, updateResult.State))
                .StartWith(init)
                .Select(updateResult =>
                {
                    var result = view(updateResult.State, dispatch);
                    return (View: result, Cmd: updateResult.Cmd);
                })
                .ObserveOn(dispatcherScheduler)
                .Subscribe(p =>
                {
                    var oldContent = getter();
                    var newContent = p.View.Materialize(Optional(oldContent));
                    viewSubscriptionsDisposable.Disposable = newContent;
                    if (!ReferenceEquals(oldContent, newContent.Resource))
                    {
                        setter(newContent.Resource);
                    }

                    p.Cmd.Subs.ForEach(sub => sub(dispatch));
                });
        }
    }
}
