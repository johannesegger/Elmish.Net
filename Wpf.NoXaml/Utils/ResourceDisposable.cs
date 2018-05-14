using System;
using System.Collections.Generic;
using System.Reactive.Disposables;

namespace Wpf.NoXaml.Utils
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

    public static class ResourceDisposable
    {
        public static IResourceDisposable<T> Create<T>(T resource, IDisposable disposable)
        {
            return new ResourceDisposable<T>(resource, disposable);
        }

        public static IResourceDisposable<T> Create<T>(T resource, IEnumerable<IDisposable> disposables)
        {
            return new ResourceDisposable<T>(resource, new CompositeDisposable(disposables));
        }

        public static IResourceDisposable<T> Create<T>(T resource, params IDisposable[] disposables)
        {
            return new ResourceDisposable<T>(resource, new CompositeDisposable(disposables));
        }
    }

    public static class ResourceDisposableExtensions
    {
        public static IResourceDisposable AddDisposable(this IResourceDisposable o, IDisposable d)
        {
            return new ResourceDisposable<object>(o.Resource, new CompositeDisposable(o, d));
        }

        public static IResourceDisposable<T> AddDisposable<T>(this IResourceDisposable<T> o, IDisposable d)
        {
            return new ResourceDisposable<T>(o.Resource, new CompositeDisposable(o, d));
        }
    }
}
