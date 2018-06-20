using System;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Linq.Expressions;
using System.Text;

namespace Elmish.Net.Utils
{
    internal class PropertyExpressionCache
    {
        private readonly ConcurrentDictionary<string, (object getter, object setter)> expressionCache =
            new ConcurrentDictionary<string, (object getter, object setter)>();

        public (Func<TObj, TProp> getter, Action<TObj, TProp> setter) Lookup<TObj, TProp>(
            Expression<Func<TObj, TProp>> expression)
        {
            var (getter, setter) = expressionCache.GetOrAdd(
                GetUniqueId(expression),
                _ => ((expression.Compile(), expression.CreateSetter())));
            return ((Func<TObj, TProp>)getter, (Action<TObj, TProp>)setter);
        }

        private static string GetUniqueId(LambdaExpression expression)
        {
            var visitor = new PropertyExpressionUniqueIdVisitor();
            visitor.Visit(expression);
            return visitor.Id;
        }

        private class PropertyExpressionUniqueIdVisitor : ExpressionVisitor
        {
            private string inType = "<unknown>";
            private string outType = "<unknown>";
            private IImmutableList<string> members = ImmutableList<string>.Empty;

            public string Id => $"{inType}::{string.Join(".", members)}::{outType}";

            protected override Expression VisitMember(MemberExpression node)
            {
                var result = base.VisitMember(node);
                members = members.Add(node.Member.Name);
                return result;
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                var result = base.VisitParameter(node);
                inType = node.Type.FullName;
                return result;
            }

            protected override Expression VisitLambda<T>(Expression<T> node)
            {
                var result = node.Update(Visit(node.Body), node.Parameters);
                outType = node.ReturnType.FullName;
                return result;
            }
        }
    }
}