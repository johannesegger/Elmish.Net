using System;
using System.Numerics;

namespace Wpf.Elmish.Net.Sample.Utils
{
    public static class VectorExtensions
    {
        public static Vector2 GetNearestPointAt(this Vector2 point, Vector2 line)
        {
            var lineVectorUnit = Vector2.Normalize(line);
            var pointVectorScaled = Vector2.Divide(point, line.Length());
            var t = Vector2.Dot(lineVectorUnit, pointVectorScaled);
            var clampedT = Math.Min(Math.Max(t, 0), 1);
            return Vector2.Multiply(line, clampedT);
        }
    }
}
