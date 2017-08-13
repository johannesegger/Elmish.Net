using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Reflection;
using System.Windows;
using Expression = System.Linq.Expressions.Expression;

namespace Wpf.NoXaml.Utils
{
    public static class ObservablePropertyExtensions
    {
        public static IObservable<TProperty> Changed<TObj, TProperty>(
            this TObj obj,
            Expression<Func<TObj, TProperty>> propertyExpr)
        {
            return GetPropertyExpressions((MemberExpression)propertyExpr.Body)
                .Aggregate(
                    Observable.Return<object>(obj),
                    (viewModelObservable, expr) => viewModelObservable
                        .Select(o =>
                        {
                            if (o == null)
                            {
                                return Observable.Return(GetDefaultValue(expr.ReturnType));
                            }
                            else
                            {
                                var getValue = expr.Compile();
                                if (o is INotifyPropertyChanged inpc)
                                {
                                    return GetPropertyObservableFromInpcObject(
                                        inpc,
                                        ((MemberExpression)expr.Body).Member.Name,
                                        getValue);
                                }
                                if (o is DependencyObject dependencyObject)
                                {
                                    return GetPropertyObservableFromDependencyObject(
                                        dependencyObject,
                                        ((MemberExpression)expr.Body).Member.DeclaringType,
                                        ((MemberExpression)expr.Body).Member.Name,
                                        getValue);
                                }
                                else
                                {
                                    return Observable.Return(getValue.DynamicInvoke(o));
                                }
                            }
                        })
                        .Switch(),
                    o => o.Cast<TProperty>())
                .DistinctUntilChanged(EqualityComparer<TProperty>.Default);
        }

        private static object GetDefaultValue(Type type)
        {
            return type.GetTypeInfo().IsValueType ? Activator.CreateInstance(type) : null;
        }

        private static IObservable<object> GetPropertyObservableFromInpcObject(
            INotifyPropertyChanged viewModel,
            string propertyName,
            Delegate getValue)
        {
            return Observable
                .FromEventPattern<PropertyChangedEventHandler, PropertyChangedEventArgs>(
                    h => viewModel.PropertyChanged += h,
                    h => viewModel.PropertyChanged -= h)
                .Where(p => p.EventArgs.PropertyName.Equals(propertyName))
                .Select(p => p.Sender)
                .StartWith(viewModel)
                .Select(p => getValue.DynamicInvoke(p));
        }

        private static IObservable<object> GetPropertyObservableFromDependencyObject(
            DependencyObject dependencyObject,
            Type declaringType,
            string propertyName,
            Delegate getValue)
        {
            var dependencyPropertyProperty = declaringType
                .GetField(propertyName + "Property", BindingFlags.Public | BindingFlags.Static);
            if (dependencyPropertyProperty == null)
            {
                throw new ArgumentException(
                    $"Can't find dependency property for {declaringType.FullName}.{propertyName}");
            }
            if (dependencyPropertyProperty.FieldType != typeof(DependencyProperty))
            {
                throw new ArgumentException(
                    $"{declaringType.FullName}.{dependencyPropertyProperty.Name} is not a dependency property");
            }

            var descriptor = DependencyPropertyDescriptor
                .FromProperty((DependencyProperty)dependencyPropertyProperty.GetValue(null), declaringType);
            return Observable
                .Create<object>(obs =>
                {
                    var eventHandler = new EventHandler((s, e) => obs.OnNext(s));
                    descriptor.AddValueChanged(dependencyObject, eventHandler);
                    return Disposable.Create(() => descriptor.RemoveValueChanged(dependencyObject, eventHandler));
                })
                .StartWith(dependencyObject)
                .Select(p => getValue.DynamicInvoke(p));
        }

        private static IEnumerable<LambdaExpression> GetPropertyExpressions(MemberExpression expr)
        {
            if (expr == null)
            {
                yield break;
            }

            foreach (var parentExpression in GetPropertyExpressions(expr.Expression as MemberExpression))
            {
                yield return parentExpression;
            }

            var param = Expression.Parameter(expr.Expression.Type, "p");
            yield return Expression.Lambda(Expression.Property(param, (PropertyInfo)expr.Member), param);
        }
    }
}
