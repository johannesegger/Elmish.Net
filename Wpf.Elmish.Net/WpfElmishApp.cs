using Elmish.Net;
using Elmish.Net.VDom;
using System;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Media;

namespace Wpf.Elmish.Net
{
    public static class WpfElmishApp
    {
        public static void Run<TState, TMessage>(
            Application app,
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVDomNode<Window>> view,
            Func<TState, Sub<TMessage>> subscriptions)
        {
            var requestAnimationFrame = Observable
                .FromEventPattern(
                    h => CompositionTarget.Rendering += h,
                    h => CompositionTarget.Rendering -= h)
                .Select(_ => Unit.Default);
            ElmishApp.Run(
                requestAnimationFrame,
                init,
                update,
                view,
                subscriptions,
                DispatcherScheduler.Current,
                () => app.MainWindow);
            app.Run();
        }

        public static void Run<TState, TMessage>(
            Application app,
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVDomNode<Window>> view)
        {
            Run(app, init, update, view, _ => Sub.None<TMessage>());
        }
    }
}