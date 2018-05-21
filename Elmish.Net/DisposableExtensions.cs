using System;
using System.Reactive.Disposables;

namespace Elmish.Net
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
