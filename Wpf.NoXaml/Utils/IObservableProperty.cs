using System;

namespace Wpf.NoXaml.Utils
{
    public interface IObservableProperty<out T> : IObservable<T>
    {
        T Value { get; }
    }
}