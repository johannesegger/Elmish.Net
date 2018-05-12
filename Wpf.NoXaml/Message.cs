using OneOf;

namespace Wpf.NoXaml
{
    public abstract class Message : OneOfBase<
        Message.MoveLocationMessage,
        Message.ChangeMapViewMessage>
    {
        public class MoveLocationMessage : Message
        {
            public MoveLocationMessage(Area area, int coordinateIndex, Coordinate coordinate)
            {
                Area = area;
                CoordinateIndex = coordinateIndex;
                Coordinate = coordinate;
            }

            public Area Area { get; }
            public int CoordinateIndex { get; }
            public Coordinate Coordinate { get; }
        }

        public class ChangeMapViewMessage : Message
        {
            public ChangeMapViewMessage(double zoomLevel, Coordinate center)
            {
                ZoomLevel = zoomLevel;
                Center = center;
            }

            public double ZoomLevel { get; }
            public Coordinate Center { get; }
        }
    }
}
