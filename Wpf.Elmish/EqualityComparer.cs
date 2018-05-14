using System;
using System.Collections.Generic;

namespace Wpf.Elmish
{
    public static class EqualityComparer
    {
        public static IEqualityComparer<T> Create<T, TProp>(Func<T, TProp> selector)
        {
            return new GenericEqualityComparer<T>(
                (x, y) => Equals(selector(x), selector(y)),
                x => selector(x)?.GetHashCode() ?? 0
            );
        }
    }
}