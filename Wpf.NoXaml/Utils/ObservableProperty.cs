using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Wpf.NoXaml.Utils
{
    public static class ObservableProperty
    {
        public static IObservableProperty<T> Create<T>(BehaviorSubject<T> subject)
        {
            return new GenericObservableProperty<T>(subject.AsObservable(), () => subject.Value);
        }

        public static IObservableProperty<TOut> Select<TIn, TOut>(this IObservableProperty<TIn> @in, Func<TIn, TOut> map)
        {
            return new GenericObservableProperty<TOut>(
                @in.AsObservable().Select(map),
                () => map(@in.Value));
        }

        private class GenericObservableProperty<T> : IObservableProperty<T>
        {
            private readonly IObservable<T> _observable;
            private readonly Func<T> _getValue;

            public T Value => _getValue();

            public GenericObservableProperty(IObservable<T> observable, Func<T> getValue)
            {
                _observable = observable;
                _getValue = getValue;
            }

            public IDisposable Subscribe(IObserver<T> observer)
            {
                return _observable.Subscribe(observer);
            }
        }
    }
}