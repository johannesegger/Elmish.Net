using Microsoft.Maps.MapControl.WPF;
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

        public static Location ToLocation(this Coordinate coordinate)
        {
            return new Location(coordinate.Latitude, coordinate.Longitude);
        }

        public static Coordinate ToCoordinate(this Location location)
        {
            return new Coordinate(location.Latitude, location.Longitude);
        }

        public static Point ToViewportPoint(this Location location, Map map)
        {
            return map.LocationToViewportPoint(location);
        }
    }
}
