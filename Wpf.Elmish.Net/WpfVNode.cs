using Elmish.Net;
using System.Windows;

namespace Wpf.Elmish.Net
{
    public static class WpfVNode
    {
        public static IVNode<T> Create<T>()
            where T : DependencyObject, new()
        {
            return VNode.Create<T>();
        }
    }

    public static class VNodeExtensions
    {
        public static IVNode<T> Attach<T, TProp>(
            this IVNode<T> vNode,
            DependencyProperty dependencyProperty,
            TProp value)
            where T : DependencyObject
        {
            return new VNode<T>(node =>
            {
                var o = vNode.Materialize(node);
                o.Resource.SetValue(dependencyProperty, value);
                return o;
            });
        }
    }
}