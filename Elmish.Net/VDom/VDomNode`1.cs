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
    public class VDomNode<T, TMessage> : IVDomNode<T, TMessage>
    {
        private readonly Func<T> factory;
        private readonly IImmutableList<IVDomNodeProperty<T, TMessage>> properties;
        private readonly Func<T, ISub<TMessage>> subscribe;

        public VDomNode(
            Func<T> factory,
            IImmutableList<IVDomNodeProperty<T, TMessage>> properties,
            Func<T, ISub<TMessage>> subscribe)
        {
            this.factory = factory;
            this.properties = properties;
            this.subscribe = subscribe;
        }

        public IReadOnlyCollection<IVDomNodeProperty> Properties => properties;

        public IVDomNode<T, TMessage> AddProperty(IVDomNodeProperty<T, TMessage> property)
        {
            return new VDomNode<T, TMessage>(factory, properties.Add(property), subscribe);
        }

        public IVDomNode<T, TMessage> AddSubscription(Func<T, ISub<TMessage>> fn)
        {
            return new VDomNode<T, TMessage>(factory, properties, o => Sub.Batch(subscribe(o), fn(o)));
        }

        MergeResult<TMessage> IVDomNode<TMessage>.MergeWith(Option<IVDomNode<TMessage>> node)
        {
            var fn = MergeWith(node.TryCast<IVDomNode<T, TMessage>>());
            return o => 
            {
                var (r, d) = fn(o.TryCast<T>());
                // Need to explicitely cast Option<T> to Option<object>
                // Otherwise it is implicitely cast to Option<Option<T>>
                return (r.TryCast<object>(), d);
            };
        }

        public MergeResult<TMessage, T> MergeWith(Option<IVDomNode<T, TMessage>> node)
        {
            var nodeProperties = node
                .Some(p => p.Properties)
                .None(ImmutableList<IVDomNodeProperty>.Empty);
            var acts = properties
                .Select(prop =>
                {
                    var existingProp = nodeProperties
                        .OfType<IVDomNodeProperty<T, TMessage>>()
                        .FirstOrDefault(p => p.CanMergeWith(prop));
                    var apply = prop.MergeWith(existingProp);
                    return new Func<T, ISub<TMessage>>(o => apply(o));
                })
                .ToList();
            var act = new Func<T, ISub<TMessage>>(o => Sub.Batch(acts.Select(a => a(o))));
            return node
                .Some(n => new MergeResult<TMessage, T>(o =>
                {
                    var sub = Sub.Batch(
                        o.Some(act).None(Sub.None<TMessage>()),
                        o.Some(subscribe).None(Sub.None<TMessage>())
                    );
                    return (None, sub);
                }))
                .None(new MergeResult<TMessage, T>(_ =>
                {
                    var t = factory();
                    var sub = Sub.Batch(
                        subscribe(t),
                        act(t)
                    );
                    var result = (Some(t), sub);
                    return result;
                }));
        }
    }
}