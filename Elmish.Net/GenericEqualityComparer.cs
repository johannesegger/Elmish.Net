using System;
using System.Collections.Generic;

namespace Elmish.Net
{
    internal class GenericEqualityComparer<T> : IEqualityComparer<T>
    {
        private readonly Func<T, T, bool> equals;
        private readonly Func<T, int> getHashCode;

        public GenericEqualityComparer(Func<T, T, bool> equals, Func<T, int> getHashCode)
        {
            this.equals = equals;
            this.getHashCode = getHashCode;
        }

        public bool Equals(T x, T y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            return this.equals(x, y);
        }

        public int GetHashCode(T obj)
        {
            if (ReferenceEquals(obj, null)) return 0;
            return this.getHashCode(obj);
        }
    }
}