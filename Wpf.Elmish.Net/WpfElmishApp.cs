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
            Func<TState, Dispatch<TMessage>, IVDomNode<Window>> view)
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
                TaskPoolScheduler.Default,
                DispatcherScheduler.Current,
                () => app.MainWindow);
            app.Run();
        }
    }
}