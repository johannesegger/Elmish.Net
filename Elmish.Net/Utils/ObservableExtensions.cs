using System;
using System.Collections.Concurrent;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Elmish.Net.Utils
{
    internal static class ObservableExtensions
    {
        /// <summary>
        /// Executes a function for each item in `source`, but skips items while `fn` is executing.
        /// </summary>
        public static IObservable<TOut> SkipIntermediate<TIn, TOut>(this IObservable<TIn> source, Func<TIn, TOut> fn)
        {
            return Observable.Create<TOut>(observer =>
            {
                var d = new CompositeDisposable();

                var gate = new object();
                var items = new BlockingCollection<TIn>(new ConcurrentQueue<TIn>());
                source
                    .Subscribe(items.Add)
                    .DisposeWith(d);

                var ct = new CancellationDisposable()
                    .DisposeWith(d)
                    .Token;
                var t = Task.Run(() =>
                {
                    try
                    {
                        while (true)
                        {
                            var currentItem = items.Take(ct); // TODO async wait would be nicer
                            while (items.TryTake(out var item))
                            {
                                currentItem = item;
                            }
                            observer.OnNext(fn(currentItem));
                        }
                    }
                    catch(OperationCanceledException)
                    {
                    }
                });

                return d;
            });
        }
    }
}
