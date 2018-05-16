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
            Center = center ?? throw new ArgumentNullException(nameof(center));
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
        public static readonly Area Empty = new Area(new DraggableCoordinate[0], "", false);

        public Area(IEnumerable<DraggableCoordinate> coordinates, string note, bool isSelected)
        {
            Coordinates = coordinates?.ToImmutableList() ?? throw new ArgumentNullException(nameof(coordinates));
            Note = note ?? throw new ArgumentNullException(nameof(note));
            IsSelected = isSelected;
        }

        public ImmutableList<DraggableCoordinate> Coordinates { get; }
        public string Note { get; }
        public bool IsSelected { get; }

        public static Area Create(IEnumerable<DraggableCoordinate> coordinates, string note)
        {
            return new Area(coordinates, note, isSelected: false);
        }
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
            Coordinate = coordinate ?? throw new ArgumentNullException(nameof(coordinate));
            IsDragging = isDragging;
        }

        public Coordinate Coordinate { get; }
        public bool IsDragging { get; }

        public static DraggableCoordinate Create(double latitude, double longitude)
        {
            return new DraggableCoordinate(new Coordinate(latitude, longitude), isDragging: false);
        }
    }
}