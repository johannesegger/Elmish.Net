using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace Wpf.Elmish.Test
{
    public class ExpressionsExtensionsTest
    {
        [Fact]
        public void CreateSetterShouldReturnNullWhenPropertyDoesntHaveASetter()
        {
            Expression<Func<A, int>> expr = a => a.PropA;
            expr.CreateSetter().Should().BeNull();
        }

        [Fact]
        public void CreateSetterShouldCastIfPropertyTypesDontMatch()
        {
            Expression<Func<A, IEnumerable<object>>> expr = p => p.PropB;
            var a = new A();
            expr.CreateSetter()(a, new List<object> { 1, 2, 3 });
            a.PropB.Should().BeEquivalentTo(new[] { 1, 2, 3 });
        }

        private class A
        {
            public int PropA { get; }
            public List<object> PropB { get; set; }
        }
    }
}
