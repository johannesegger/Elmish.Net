using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Wpf.NoXaml.Utils
{
    public static class Lens
    {
        public static Lens<T> Create<T>(BehaviorSubject<T> rootSubject)
        {
            return new Lens<T>(
                ObservableProperty.Create(rootSubject),
                rootSubject.OnNext);
        }

        public static IObservable<IEnumerable<Lens<T>>> FocusItems<T>(
            this Lens<IImmutableList<T>> lens)
        {
            return lens
                .Select(values => values
                    .Select((v, i) =>
                    {
                        var parameter = Expression.Parameter(typeof(IImmutableList<T>), "p");
                        var indexProperty = typeof(IReadOnlyList<T>).GetProperty("Item", typeof(T), new[] { typeof(int) });
                        var indexExpression = Expression.MakeIndex(parameter, indexProperty, new[] { Expression.Constant(i) });
                        var expr = Expression.Lambda<Func<IImmutableList<T>, T>>(indexExpression, parameter);
                        return lens.Focus(expr);
                    })
                );
        }

        public static void Update<T>(this Lens<T> lens, Func<T, T> action)
        {
            lens.Get()
                .Then(action)
                .Then(lens.Set);
        }

        public static T Exchange<T>(this Lens<T> lens, T value)
        {
            var current = lens.Get();
            lens.Set(value);
            return current;
        }

        public static void ExecuteAtomic<T>(this Lens<T> lens, Action<Lens<T>> action)
        {
            var subject = new BehaviorSubject<T>(lens.Get());
            Create(subject)
                .Then(action);
            lens.Set(subject.Value);
        }
    }

    public class Lens<T> : IObservable<T>
    {
        private readonly IObservableProperty<T> _observableProperty;
        private readonly Action<T> _set;

        public T Get() => _observableProperty.Value;

        public void Set(T value)
        {
            if (!Equals(value, Get()))
            {
                _set(value);
            }
        }

        public Lens(IObservableProperty<T> observableProperty, Action<T> set)
        {
            _observableProperty = observableProperty;
            _set = set;
        }

        public Lens<TProp> Focus<TProp>(Expression<Func<T, TProp>> propertyExpression)
        {
            var getValue = propertyExpression.Compile();
            var setValue = propertyExpression.CreateImmutableSetter();
            var observableProperty = _observableProperty.Select(getValue);
            return new Lens<TProp>(observableProperty, v => Set(setValue(Get(), v)));
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            return _observableProperty
                .DistinctUntilChanged()
                .Subscribe(observer);
        }
    }
}