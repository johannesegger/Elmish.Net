using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Disposables;
using System.Reflection;

namespace Elmish.Net.VDom
{
    public static class VDomNode
    {
        public static IVDomNode<T, TMessage> Set<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, TProp>> propertyExpression,
            TProp value,
            IEqualityComparer<TProp> equalityComparer)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeSimpleProperty<T, TMessage, TProp>(propertyInfo, value, equalityComparer));
        }

        public static IVDomNode<T, TMessage> Set<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, TProp>> propertyExpression,
            TProp value)
        {
            return node.Set(propertyExpression, value, EqualityComparer<TProp>.Default);
        }

        public static IVDomNode<T, TMessage> Set<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, TProp>> propertyExpression,
            IVDomNode<TProp, TMessage> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildNodeProperty<T, TMessage, TProp>(propertyInfo, value));
        }

        public static IVDomNode<T, TMessage> SetChildNodes<T, TMessage>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            IEnumerable<IVDomNode<TMessage>> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildNodeCollectionProperty<T, TMessage>(propertyInfo, value.ToImmutableList()));
        }

        public static IVDomNode<T, TMessage> SetChildNodes<T, TMessage>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            params IVDomNode<TMessage>[] value)
        {
            return node.SetChildNodes(propertyExpression, value.AsEnumerable());
        }

        public static IVDomNode<T, TMessage> SetCollection<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            IEnumerable<TProp> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildCollectionProperty<T, TMessage, TProp>(propertyInfo, value.ToImmutableList(), EqualityComparer<TProp>.Default));
        }

        public static IVDomNode<T, TMessage> SetCollection<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            params TProp[] value)
        {
            return node.SetCollection(propertyExpression, value.AsEnumerable());
        }

        public static IVDomNode<T, TMessage> SetCollection<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, System.Collections.IEnumerable>> propertyExpression,
            IEnumerable<TProp> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildSequenceProperty<T, TMessage, TProp>(propertyInfo, value.ToImmutableList(), EqualityComparer<TProp>.Default));
        }

        public static IVDomNode<T, TMessage> SetCollection<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            Expression<Func<T, System.Collections.IEnumerable>> propertyExpression,
            params TProp[] value)
        {
            return node.SetCollection(propertyExpression, value.AsEnumerable());
        }

        public static IVDomNode<T, TMessage> Subscribe<T, TKey, TMessage>(
            this IVDomNode<T, TMessage> node,
            Func<T, TKey> keyFn,
            Func<TKey, IObservable<TMessage>> fn)
        {
            return node.AddSubscription(o => Sub.Create(keyFn(o), fn));
        }

        public static IVDomNode<T, TMessage> Subscribe<T, TMessage>(
            this IVDomNode<T, TMessage> node,
            Func<T, IObservable<TMessage>> fn)
        {
            return node.Subscribe(o => o, fn);
        }

        public static IVDomNode<T, TMessage> Subscribe<T, TKey, TMessage>(
            this IVDomNode<T, TMessage> node,
            TKey key,
            Func<TKey, IObservable<TMessage>> fn)
        {
            return node.Subscribe(_ => key, fn);
        }
    }
}