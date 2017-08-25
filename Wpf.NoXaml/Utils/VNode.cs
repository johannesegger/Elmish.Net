using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;

namespace Wpf.NoXaml.Utils
{
    public interface IVNode
    {
        object Materialize();
    }

    public class VNode<T> : IVNode
    {
        private readonly Func<T> _create;

        public VNode(Func<T> create)
        {
            _create = create;
        }

        object IVNode.Materialize() => Materialize();
        public T Materialize() => _create();
    }

    public static class VNode
    {
        public static VNode<T> Create<T>()
            where T : DependencyObject, new()
        {
            return new VNode<T>(() => new T());
        }
    }

    public static class VNodeExtensions
    {
        public static VNode<T> Set<T, TProp>(this VNode<T> node, Expression<Func<T, TProp>> propertyExpression, VNode<TProp> value)
        {
            var setter = propertyExpression.CreateSetter();
            return new VNode<T>(() =>
            {
                var o = node.Materialize();
                setter(o, value.Materialize());
                return o;
            });
        }

        public static VNode<T> Set<T>(this VNode<T> node, Expression<Func<T, IList>> propertyExpression, params IVNode[] nodes)
        {
            return node.Set(propertyExpression, nodes.AsEnumerable());
        }

        public static VNode<T> Set<T>(this VNode<T> node, Expression<Func<T, IList>> propertyExpression, IEnumerable<IVNode> nodes)
        {
            var getter = propertyExpression.Compile();
            var nodeList = nodes.ToList();
            return new VNode<T>(() =>
            {
                var o = node.Materialize();
                var collection = getter(o);
                nodeList
                    .Select(n => n.Materialize())
                    .ForEach(n => collection.Add(n));
                return o;
            });
        }

        public static VNode<T> Set<T, TProp>(this VNode<T> node, Expression<Func<T, TProp>> propertyExpression, TProp value)
        {
            var setter = propertyExpression.CreateSetter();
            return new VNode<T>(() =>
            {
                var o = node.Materialize();
                setter(o, value);
                return o;
            });
        }

        public static VNode<T> OnEvent<T, TProp>(
            this VNode<T> node,
            Expression<Func<T, IObservable<TProp>>> propertyExpression,
            Action<TProp> dispatchMessage)
        {
            var getter = propertyExpression.Compile();
            return new VNode<T>(() =>
            {
                var o = node.Materialize();
                getter(o)
                    .Subscribe(dispatchMessage); // TODO dispose subscription
                return o;
            });
        }

        public static VNode<T> Attach<T, TProp>(this VNode<T> node, DependencyProperty dependencyProperty, TProp value)
            where T : DependencyObject
        {
            return new VNode<T>(() =>
            {
                var o = node.Materialize();
                o.SetValue(dependencyProperty, value);
                return o;
            });
        }
    }
}
