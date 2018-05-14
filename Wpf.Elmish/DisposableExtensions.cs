using System;
using System.Reactive.Disposables;

namespace Wpf.Elmish
{
    public static class DisposableExtensions
    {
        public static T DisposeWith<T>(this T disposable, CompositeDisposable container)
            where T : IDisposable
        {
            container.Add(disposable);
            return disposable;
        }
    }
}
