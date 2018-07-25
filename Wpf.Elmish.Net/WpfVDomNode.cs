using Elmish.Net;
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
    public static class VDomNodeExtensions
    {
        public static IVDomNode<T, TMessage> Attach<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            DependencyProperty dependencyProperty,
            TProp value,
            IEqualityComparer<TProp> equalityComparer)
            where T : DependencyObject
        {
            return node.AddProperty(new VDomNodeAttachedProperty<T, TMessage, TProp>(dependencyProperty, value, equalityComparer));
        }

        public static IVDomNode<T, TMessage> Attach<T, TMessage, TProp>(
            this IVDomNode<T, TMessage> node,
            DependencyProperty dependencyProperty,
            TProp value)
            where T : DependencyObject
        {
            return node.Attach(dependencyProperty, value, EqualityComparer<TProp>.Default);
        }

        private class VDomNodeAttachedProperty<TParent, TMessage, TValue>
            : IVDomNodeProperty<TParent, TMessage, TValue>
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

            public Func<TParent, ISub<TMessage>> MergeWith(IVDomNodeProperty property)
            {
                return Optional(property)
                    .TryCast<IVDomNodeProperty<TParent, TMessage, TValue>>()
                    .Bind(p =>
                        equalityComparer.Equals(p.Value, Value)
                        ? Some(Unit.Default)
                        : None
                    )
                    .Some(_ => new Func<TParent, ISub<TMessage>>(o => Sub.None<TMessage>()))
                    .None(() => new Func<TParent, ISub<TMessage>>(o =>
                        {
                            o.SetValue(dependencyProperty, Value);
                            return Sub.None<TMessage>();
                        }));
            }

            public bool CanMergeWith(IVDomNodeProperty property)
            {
                return property is VDomNodeAttachedProperty<TParent, TMessage, TValue> p
                    && dependencyProperty.GlobalIndex == p.dependencyProperty.GlobalIndex;
            }
        }
    }
}