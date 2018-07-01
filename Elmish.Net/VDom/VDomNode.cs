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
        public static IVDomNode<T> Create<T>()
            where T : new()
        {
            return new VDomNode<T>(
                () => new T(),
                ImmutableList<IVDomNodeProperty<T>>.Empty,
                o => Disposable.Empty);
        }

        public static IVDomNode<T> Set<T, TProp>(
            this IVDomNode<T> node,
            Expression<Func<T, TProp>> propertyExpression,
            TProp value,
            IEqualityComparer<TProp> equalityComparer)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeSimpleProperty<T, TProp>(propertyInfo, value, equalityComparer));
        }

        public static IVDomNode<T> Set<T, TProp>(
            this IVDomNode<T> node,
            Expression<Func<T, TProp>> propertyExpression,
            TProp value)
        {
            return node.Set(propertyExpression, value, EqualityComparer<TProp>.Default);
        }

        public static IVDomNode<T> Set<T, TProp>(
            this IVDomNode<T> node,
            Expression<Func<T, TProp>> propertyExpression,
            IVDomNode<TProp> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildNodeProperty<T, TProp>(propertyInfo, value));
        }

        public static IVDomNode<T> SetChildNodes<T>(
            this IVDomNode<T> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            IEnumerable<IVDomNode> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildNodeCollectionProperty<T>(propertyInfo, value.ToImmutableList()));
        }

        public static IVDomNode<T> SetChildNodes<T>(
            this IVDomNode<T> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            params IVDomNode[] value)
        {
            return node.SetChildNodes(propertyExpression, value.AsEnumerable());
        }

        public static IVDomNode<T> SetCollection<T, TProp>(
            this IVDomNode<T> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            IEnumerable<TProp> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildCollectionProperty<T, TProp>(propertyInfo, value.ToImmutableList(), EqualityComparer<TProp>.Default));
        }

        public static IVDomNode<T> SetCollection<T, TProp>(
            this IVDomNode<T> node,
            Expression<Func<T, System.Collections.IList>> propertyExpression,
            params TProp[] value)
        {
            return node.SetCollection(propertyExpression, value.AsEnumerable());
        }

        public static IVDomNode<T> SetCollection<T, TProp>(
            this IVDomNode<T> node,
            Expression<Func<T, System.Collections.IEnumerable>> propertyExpression,
            IEnumerable<TProp> value)
        {
            var propertyInfo = (PropertyInfo)((MemberExpression)propertyExpression.Body).Member;
            return node.AddProperty(new VDomNodeChildSequenceProperty<T, TProp>(propertyInfo, value.ToImmutableList(), EqualityComparer<TProp>.Default));
        }

        public static IVDomNode<T> SetCollection<T, TProp>(
            this IVDomNode<T> node,
            Expression<Func<T, System.Collections.IEnumerable>> propertyExpression,
            params TProp[] value)
        {
            return node.SetCollection(propertyExpression, value.AsEnumerable());
        }

        public static IVDomNode<T> Subscribe<T>(
            this IVDomNode<T> node,
            Func<T, IDisposable> fn)
        {
            return node.AddSubscription(fn);
        }
    }
}