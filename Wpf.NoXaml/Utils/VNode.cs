using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Wpf.NoXaml.Utils
{
    public interface IVNode
    {
        object Materialize(Option<object> node);
    }

    public interface IVNode<T> : IVNode
    {
        T Materialize(Option<T> node);
    }

    public class VNode<T> : IVNode<T>
    {
        private readonly Func<Option<T>, T> _createOrUpdate;

        public VNode(Func<Option<T>, T> createOrUpdate)
        {
            _createOrUpdate = createOrUpdate;
        }

        object IVNode.Materialize(Option<object> node) => Materialize(node.OfType<T>());
        public T Materialize(Option<T> node) => _createOrUpdate(node);
    }

    public static class VNode
    {
        public static IVNode<T> Create<T>()
            where T : DependencyObject, new()
        {
            return new VNode<T>(node => node.IfNone(() => new T()));
        }

        public static IVNode<TBase> Create<TBase, TImpl>()
            where TBase : DependencyObject
            where TImpl : TBase, new()
        {
            return new VNode<TBase>(node => node.IfNone(() => new TImpl()));
        }
    }

    public static class VNodeExtensions
    {
        private static IVNode<T> Set<T, TProp>(
            this IVNode<T> vNode,
            Expression<Func<T, TProp>> propertyExpression,
            Func<Option<TProp>, TProp> getValue,
            IEqualityComparer<TProp> equalityComparer)
        {
            var getter = propertyExpression.Compile();
            var setter = propertyExpression.CreateSetter();
            return new VNode<T>(node =>
            {
                var o = vNode.Materialize(node);
                var existingValue = getter(o);
                var value = getValue(existingValue);
                if (!equalityComparer.Equals(value, existingValue))
                {
                    setter(o, value);
                }
                return o;
            });
        }

        public static IVNode<T> Set<T, TProp>(
            this IVNode<T> node,
            Expression<Func<T, TProp>> propertyExpression,
            IVNode<TProp> value)
        {
            return node.Set(
                propertyExpression,
                o => value.Materialize(o),
                EqualityComparer<TProp>.Default);
        }

        public static IVNode<T> Set<T, TProp>(
            this IVNode<T> node,
            Expression<Func<T, TProp>> propertyExpression,
            TProp value,
            IEqualityComparer<TProp> equalityComparer)
        {
            return node.Set(propertyExpression, _ => value, equalityComparer);
        }

        public static IVNode<T> Set<T, TProp>(
            this IVNode<T> node,
            Expression<Func<T, TProp>> propertyExpression,
            TProp value)
        {
            return node.Set(propertyExpression, value, EqualityComparer<TProp>.Default);
        }

        public static IVNode<T> SetChildren<T>(
            this IVNode<T> vNode,
            Expression<Func<T, IList>> propertyExpression,
            params IVNode[] children)
        {
            var getter = propertyExpression.Compile();
            return new VNode<T>(node =>
            {
                var oldCollection = node
                    .Some(getter)
                    .None(new List<object>());

                var o = vNode.Materialize(node);
                var newCollection = getter(o);
                for (var i = 0; i < children.Length; i++)
                {
                    var oldItem = oldCollection.Count > i ? Some(oldCollection[i]) : None;
                    var newItem = children[i].Materialize(oldItem);
                    if (ReferenceEquals(oldCollection, newCollection))
                    {
                        oldItem
                            .Match(
                                p =>
                                {
                                    if (!ReferenceEquals(p, newItem))
                                    {
                                        newCollection[i] = newItem;
                                    }
                                },
                                () => newCollection.Add(newItem));
                    }
                    else
                    {
                        newCollection.Add(newItem);
                    }
                }
                return o;
            });
        }

        public static IVNode<T> SetChildren<T>(
            this IVNode<T> node,
            Expression<Func<T, IList>> propertyExpression,
            IEnumerable<IVNode> children)
        {
            return node.SetChildren(propertyExpression, children.ToArray());
        }

        public static IVNode<T> SetChildren<T>(
            this IVNode<T> vNode,
            Expression<Func<T, IList>> propertyExpression,
            params object[] children)
        {
            var getter = propertyExpression.Compile();
            return new VNode<T>(node =>
            {
                var o = vNode.Materialize(node);
                var newCollection = getter(o);
                for (var i = 0; i < children.Length; i++)
                {
                    if (newCollection.Count <= i)
                    {
                        newCollection.Add(children[i]);
                    }
                    else if (!Equals(newCollection[i], children[i]))
                    {
                        newCollection[i] = children[i];
                    }
                }
                return o;
            });
        }

        public static IVNode<T> SetChildren<T>(
            this IVNode<T> node,
            Expression<Func<T, IList>> propertyExpression,
            IEnumerable<object> children)
        {
            return node.SetChildren(propertyExpression, children.ToArray());
        }

        public static IVNode<T> OnEvent<T, TProp>(
            this IVNode<T> vNode,
            Func<T, IObservable<TProp>> getter,
            Action<TProp> dispatchMessage)
        {
            return new VNode<T>(node =>
            {
                var o = vNode.Materialize(node);
                // TODO this is certainly not always correct
                // Instead find a way of disposing the subscription
                // whenever the node is not used any longer.
                if (node.Some(p => !ReferenceEquals(o, p)).None(true))
                {
                    getter(o)
                        .Subscribe(dispatchMessage);
                }
                return o;
            });
        }

        public static IVNode<T> Attach<T, TProp>(
            this IVNode<T> vNode,
            DependencyProperty dependencyProperty,
            TProp value)
            where T : DependencyObject
        {
            return new VNode<T>(node =>
            {
                var o = vNode.Materialize(node);
                o.SetValue(dependencyProperty, value);
                return o;
            });
        }
    }
}
