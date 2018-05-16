using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Wpf.Elmish
{
    public class State
    {
        public static readonly State Empty =
            new State(0, new Coordinate(0, 0), new Area[0], Area.Empty);

        public State(double mapZoomLevel, Coordinate center, IEnumerable<Area> areas, Area newArea)
        {
            MapZoomLevel = mapZoomLevel;
            Center = center;
            Areas = areas?.ToImmutableList() ?? throw new ArgumentNullException(nameof(areas));
            NewArea = newArea ?? throw new ArgumentNullException(nameof(newArea));
        }

        public double MapZoomLevel { get; }
        public Coordinate Center { get; }
        public ImmutableList<Area> Areas { get; }
        public Area NewArea { get; }
    }

    public class Area
    {
        public static readonly Area Empty = new Area(new DraggableCoordinate[0], "");

        public Area(IEnumerable<DraggableCoordinate> coordinates, string note)
        {
            Coordinates = coordinates?.ToImmutableList() ?? throw new ArgumentNullException(nameof(coordinates));
            Note = note ?? throw new ArgumentNullException(nameof(note));
        }

        public ImmutableList<DraggableCoordinate> Coordinates { get; }
        public string Note { get; }
    }

    [Equals]
    public class Coordinate
    {
        public Coordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; }
        public double Longitude { get; }
    }

    public class DraggableCoordinate
    {
        public DraggableCoordinate(Coordinate coordinate, bool isDragging)
        {
            Coordinate = coordinate;
            IsDragging = isDragging;
        }

        public static DraggableCoordinate Create(double latitude, double longitude)
        {
            return new DraggableCoordinate(new Coordinate(latitude, longitude), isDragging: false);
        }

        public Coordinate Coordinate { get; }
        public bool IsDragging { get; }
    }
}