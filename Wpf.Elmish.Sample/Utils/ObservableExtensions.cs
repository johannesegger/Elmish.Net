using LanguageExt;
using System;
using System.Linq;
using System.Reactive.Linq;

namespace Wpf.Elmish.Sample.Utils
{
    public static class ObservableExtensions
    {
        public static IObservable<TOut> Choose<TIn, TOut>(
            this IObservable<TIn> o, Func<TIn, Option<TOut>> fn)
        {
            return o
                .SelectMany(p =>
                    fn(p)
                        .Some(Observable.Return)
                        .None(Observable.Empty<TOut>())
                );
        }
    }
}
