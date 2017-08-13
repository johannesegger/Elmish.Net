using System;
using System.Reactive.Disposables;

namespace Wpf.NoXaml.Utils
{
    public static class DisposableExtensions
    {
        public static T DisposeWith<T>(this T disposable, CompositeDisposable container)
            where T : IDisposable
        {
            container.Add(disposable);
            return disposable;
        }

        public static IDisposable SubscribeDisposable<T>(this IObservable<T> observable, Func<T, IDisposable> fn)
        {
            var d = new CompositeDisposable();
            var sd = new SerialDisposable().DisposeWith(d);
            observable
                .Subscribe(p =>
                {
                    sd.Disposable = Disposable.Empty;
                    sd.Disposable = fn(p);
                })
                .DisposeWith(d);
            return d;
        }
    }
}
