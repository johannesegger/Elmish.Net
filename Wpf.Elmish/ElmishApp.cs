using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Wpf.Elmish
{
    public static class ElmishApp
    {
        public static void Run<TState, TMessage>(
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVNode> view,
            Expression<Func<object>> rootNode)
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
                .ObserveOnDispatcher()
                .Subscribe(p =>
                {
                    var content = p.View.Materialize(getter());
                    viewSubscriptionsDisposable.Disposable = content;
                    setter(content.Resource);

                    p.Cmd.Subs.ForEach(sub => sub(dispatch));
                });
        }
    }
}
