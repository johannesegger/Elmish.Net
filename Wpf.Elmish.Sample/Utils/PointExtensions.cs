using System;
using System.Windows;

namespace Wpf.Elmish.Sample.Utils
{
    public static class PointExtensions
    {
        public static double DistanceTo(this Point p1, Point p2)
        {
            var xDiff = p1.X - p2.X;
            var yDiff = p1.Y - p2.Y;
            return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
        }
    }
}
