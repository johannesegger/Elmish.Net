using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reactive.Disposables;
using Elmish.Net.Utils;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Elmish.Net.VDom
{
    public class VDomNode<T> : IVDomNode<T>
    {
        private readonly Func<T> factory;
        private readonly IImmutableList<IVDomNodeProperty<T>> properties;
        private readonly Func<T, IDisposable> subscribe;

        public VDomNode(
            Func<T> factory,
            IImmutableList<IVDomNodeProperty<T>> properties,
            Func<T, IDisposable> subscribe)
        {
            this.factory = factory;
            this.properties = properties;
            this.subscribe = subscribe;
        }

        public IReadOnlyCollection<IVDomNodeProperty> Properties => properties;

        public IVDomNode<T> AddProperty(IVDomNodeProperty<T> property)
        {
            return new VDomNode<T>(factory, properties.Add(property), subscribe);
        }

        public IVDomNode<T> AddSubscription(Func<T, IDisposable> fn)
        {
            return new VDomNode<T>(factory, properties, o => new CompositeDisposable(subscribe(o), fn(o)));
        }

        MergeResult IVDomNode.MergeWith(Option<IVDomNode> node)
        {
            var fn = MergeWith(node.TryCast<IVDomNode<T>>());
            return o =>
            {
                var (r, d) = fn(o.TryCast<T>());
                return (r.TryCast<object>(), d);
            };
        }

        public MergeResult<T> MergeWith(Option<IVDomNode<T>> node)
        {
            var nodeProperties = node
                .Some(p => p.Properties)
                .None(ImmutableList<IVDomNodeProperty>.Empty);
            var acts = properties
                .Select(prop =>
                {
                    var existingProp = nodeProperties
                        .OfType<IVDomNodeProperty<T>>()
                        .FirstOrDefault(p => p.CanMergeWith(prop));
                    var apply = prop.MergeWith(existingProp);
                    return new Func<T, IDisposable>(o => apply(o));
                })
                .ToList();
            var act = new Func<T, IDisposable>(o => new CompositeDisposable(acts.Select(a => a(o))));
            return node
                .Some(n => new MergeResult<T>(o =>
                {
                    var d = new CompositeDisposable();
                    o.Some(act).None(Disposable.Empty).DisposeWith(d);
                    o.Some(subscribe).None(Disposable.Empty).DisposeWith(d);
                    return (None, d);
                }))
                .None(new MergeResult<T>(_ =>
                {
                    var t = factory();
                    var d = new CompositeDisposable();
                    subscribe(t).DisposeWith(d);
                    act(t).DisposeWith(d);
                    return (t, d);
                }));
        }
    }
}