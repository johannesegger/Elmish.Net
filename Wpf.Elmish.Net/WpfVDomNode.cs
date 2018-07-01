using Elmish.Net.Utils;
using Elmish.Net.VDom;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Windows;
using static LanguageExt.Prelude;

namespace Wpf.Elmish.Net
{
    public static class WpfVDomNode
    {
        public static IVDomNode<T> Create<T>()
            where T : DependencyObject, new()
        {
            return VDomNode.Create<T>();
        }
    }

    public static class VDomNodeExtensions
    {
        public static IVDomNode<T> Attach<T, TProp>(
            this IVDomNode<T> node,
            DependencyProperty dependencyProperty,
            TProp value,
            IEqualityComparer<TProp> equalityComparer)
            where T : DependencyObject
        {
            return node.AddProperty(new VDomNodeAttachedProperty<T, TProp>(dependencyProperty, value, equalityComparer));
        }

        public static IVDomNode<T> Attach<T, TProp>(
            this IVDomNode<T> node,
            DependencyProperty dependencyProperty,
            TProp value)
            where T : DependencyObject
        {
            return node.Attach(dependencyProperty, value, EqualityComparer<TProp>.Default);
        }

        private class VDomNodeAttachedProperty<TParent, TValue>
            : IVDomNodeProperty<TParent, TValue>
            where TParent : DependencyObject
        {
            private readonly DependencyProperty dependencyProperty;
            private readonly IEqualityComparer<TValue> equalityComparer;

            public VDomNodeAttachedProperty(
                DependencyProperty dependencyProperty,
                TValue value,
                IEqualityComparer<TValue> equalityComparer)
            {
                this.dependencyProperty = dependencyProperty;
                Value = value;
                this.equalityComparer = equalityComparer;
            }

            public TValue Value { get; }

            public Func<TParent, IDisposable> MergeWith(IVDomNodeProperty property)
            {
                return Optional(property)
                    .TryCast<IVDomNodeProperty<TParent, TValue>>()
                    .Bind(p =>
                        equalityComparer.Equals(p.Value, Value)
                        ? Some(Unit.Default)
                        : None
                    )
                    .Some(_ => new Func<TParent, IDisposable>(o => Disposable.Empty))
                    .None(() => new Func<TParent, IDisposable>(o =>
                        {
                            o.SetValue(dependencyProperty, Value);
                            return Disposable.Empty;
                        }));
            }

            public bool CanMergeWith(IVDomNodeProperty property)
            {
                return property is VDomNodeAttachedProperty<TParent, TValue> p
                    && dependencyProperty.GlobalIndex == p.dependencyProperty.GlobalIndex;
            }
        }
    }
}