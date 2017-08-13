using System;
using System.Reactive.Disposables;
using System.Windows;

namespace Wpf.NoXaml.Utils
{
    public interface IElementBinding<out T> : IDisposable
    {
        T Element { get; }
    }

    public class ElementBinding<T> : IElementBinding<T>
        where T : DependencyObject
    {
        private readonly IDisposable _bindings;

        public T Element { get; }

        public ElementBinding(T element, IDisposable bindings)
        {
            Element = element;
            _bindings = bindings;
        }

        public ElementBinding<T> Add(IDisposable binding)
        {
            return new ElementBinding<T>(Element, new CompositeDisposable(binding));
        }

        public void Dispose()
        {
            _bindings.Dispose();
        }
    }
}
