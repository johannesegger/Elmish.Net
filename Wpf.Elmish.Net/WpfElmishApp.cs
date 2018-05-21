using Elmish.Net;
using System;
using System.Reactive.Concurrency;
using System.Windows;

namespace Wpf.Elmish.Net
{
    public static class WpfElmishApp
    {
        public static void Run<TState, TMessage>(
            Application app,
            (TState State, Cmd<TMessage> Cmd) init,
            Func<TMessage, TState, (TState, Cmd<TMessage>)> update,
            Func<TState, Dispatch<TMessage>, IVNode<Window>> view)
        {
            ElmishApp.Run(init, update, view, DispatcherScheduler.Current, () => app.MainWindow);
            app.Run();
        }
    }
}