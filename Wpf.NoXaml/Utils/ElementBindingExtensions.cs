using System;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf.NoXaml.Utils
{
    public static class ElementBindingExtensions
    {
        public static ElementBinding<T> Bind<T>(
            this T element,
            params Func<ElementBinding<T>, ElementBinding<T>>[] bindings)
            where T : DependencyObject
        {
            return bindings
                .Aggregate(
                    new ElementBinding<T>(element, Disposable.Empty),
                    (binding, fn) => fn(binding));
        }

        public static ElementBinding<T> TwoWay<T, TViewProp, TModelProp>(
            this ElementBinding<T> binding,
            Expression<Func<T, TViewProp>> propertyExpression,
            Lens<TModelProp> lens,
            Func<TViewProp, TModelProp> mapToModelValue,
            Func<TModelProp, TViewProp> mapToViewValue)
            where T : FrameworkElement
        {
            var setter = propertyExpression.CreateSetter();
            var subscription = binding
                .Element
                .DoWhileLoaded(() =>
                {
                    var d = new CompositeDisposable();

                    // Subscribe to `lens` first, because we want to propagate
                    // the initial value of the model
                    lens
                        .Subscribe(value => setter(binding.Element, mapToViewValue(value)))
                        .DisposeWith(d);

                    binding
                        .Element
                        .Changed(propertyExpression)
                        .Select(mapToModelValue)
                        .Subscribe(lens.Set)
                        .DisposeWith(d);

                    return d;
                });
            return binding.Add(subscription);
        }

        public static ElementBinding<T> TwoWay<T, TProp>(
            this ElementBinding<T> binding,
            Expression<Func<T, TProp>> propertyExpression,
            Lens<TProp> lens)
            where T : FrameworkElement
        {
            return binding.TwoWay(propertyExpression, lens, x => x, x => x);
        }

        public static ElementBinding<T> OneWay<T, TElementProp, TLensProp>(
            this ElementBinding<T> binding,
            Expression<Func<T, TElementProp>> propertyExpression,
            Lens<TLensProp> lens,
            Func<TLensProp, TElementProp> map)
            where T : FrameworkElement
        {
            var setter = propertyExpression.CreateSetter();
            var subscription = binding
                .Element
                .DoWhileLoaded(() => lens
                    .Subscribe(value => setter(binding.Element, map(value)))
                );
            return binding.Add(subscription);
        }

        public static ElementBinding<T> OneWay<T, TProp>(
            this ElementBinding<T> binding,
            Expression<Func<T, TProp>> propertyExpression,
            Lens<TProp> lens)
            where T : FrameworkElement
        {
            return binding.OneWay(propertyExpression, lens, x => x);
        }

        public static ElementBinding<T> Collection<T, TLensProp>(
            this ElementBinding<T> binding,
            Func<T, System.Collections.IList> getCollection,
            Lens<IImmutableList<TLensProp>> lens,
            Func<Lens<TLensProp>, Action<IElementBinding<DependencyObject>>, object> map)
            where T : FrameworkElement
        {
            var collection = getCollection(binding.Element);
            var subscription = binding
                .Element
                .DoWhileLoaded(() => lens
                    .FocusItems()
                    .SubscribeDisposable(itemLenses =>
                    {
                        var d = new CompositeDisposable();
                        // TODO diff between last values and current values
                        // remove old values, add new values, don't touch survived values (I think)
                        collection.Clear();
                        itemLenses
                            .Select(itemLens => map(itemLens, d.Add))
                            .ForEach(c => collection.Add(c));
                        return d;
                    })
                );
            return binding.Add(subscription);
        }

        public static ElementBinding<T> Command<T, TObs>(
            this ElementBinding<T> binding,
            IObservable<TObs> trigger,
            IObservable<bool> canExecute,
            Func<TObs, CancellationToken, Task> action)
            where T : FrameworkElement
        {
            var executingSubject = new BehaviorSubject<int>(0);
            return binding
                .Element
                .DoWhileLoaded(() =>
                {
                    // TODO extract for testing
                    var d = new CompositeDisposable();
                    trigger
                        .Select(p => Observable
                            .Using(
                                () =>
                                {
                                    executingSubject.OnNext(1);
                                    return Disposable.Create(() => executingSubject.OnNext(-1));
                                },
                                _ => Observable.FromAsync(ct => action(p, ct))
                            .Catch(Observable.Empty<Unit>())))
                        .Switch()
                        .Subscribe()
                        .DisposeWith(d);
                    canExecute
                        .CombineLatest(
                            executingSubject.Scan((a, b) => a + b),
                            (canExec, execCount) => execCount == 0 && canExec)
                        .ObserveOnDispatcher()
                        .Subscribe(isEnabled => binding.Element.IsEnabled = isEnabled)
                        .DisposeWith(d);
                    return d;
                })
                .Then(binding.Add);
        }

        public static T Register<T>(this IElementBinding<T> binding, Action<IElementBinding<DependencyObject>> register)
            where T : DependencyObject
        {
            register(binding);
            return binding.Element;
        }

        private static IDisposable DoWhileLoaded(this FrameworkElement element, Func<IDisposable> action)
        {
            var serialDisposable = new SerialDisposable();
            var loadObservable = Observable
                .FromEventPattern<RoutedEventHandler, RoutedEventArgs>(
                    h => element.Loaded += h,
                    h => element.Loaded -= h
                )
                .Select(_ => new Action(() =>
                {
                    serialDisposable.Disposable = Disposable.Empty;
                    serialDisposable.Disposable = action();
                }));

            var unloadObservable = Observable
                .FromEventPattern<RoutedEventHandler, RoutedEventArgs>(
                    h => element.Unloaded += h,
                    h => element.Unloaded -= h
                )
                .Select(_ => new Action(() =>
                {
                    serialDisposable.Disposable = Disposable.Empty;
                }));

            return loadObservable
                .Merge(unloadObservable)
                .Subscribe(act => act());
        }
    }
}