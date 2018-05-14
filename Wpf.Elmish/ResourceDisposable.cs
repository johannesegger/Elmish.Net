using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;

namespace Wpf.Elmish
{
    public interface IResourceDisposable : IDisposable
    {
        object Resource { get; }
    }

    public interface IResourceDisposable<out T> : IResourceDisposable
    {
        new T Resource { get; }
    }

    internal sealed class ResourceDisposable<T> : IResourceDisposable<T>
    {
        private readonly IDisposable disposable;

        public ResourceDisposable(T resource, IDisposable disposable)
        {
            Resource = resource;
            this.disposable = disposable;
        }

        public T Resource { get; }

        object IResourceDisposable.Resource => Resource;

        public void Dispose()
        {
            disposable.Dispose();
        }
    }

    internal static class ResourceDisposable
    {
        public static IResourceDisposable<T> Create<T>(T resource, params IDisposable[] disposables)
        {
            return new ResourceDisposable<T>(resource, new CompositeDisposable(disposables));
        }

        public static IResourceDisposable<T> Create<T>(T resource, IEnumerable<IDisposable> disposables)
        {
            return Create(resource, disposables.ToArray());
        }
    }

    internal static class ResourceDisposableExtensions
    {
        public static IResourceDisposable<T> AddDisposable<T>(this IResourceDisposable<T> o, IDisposable d)
        {
            return new ResourceDisposable<T>(o.Resource, new CompositeDisposable(o, d));
        }
    }
}
