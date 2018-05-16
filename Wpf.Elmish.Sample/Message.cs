using OneOf;

namespace Wpf.Elmish
{
    public abstract class Message : OneOfBase<
        Message.BeginMoveLocationMessage,
        Message.MoveLocationMessage,
        Message.EndMoveLocationMessage,
        Message.InsertLocationMessage,
        Message.ChangeMapViewMessage>
    {
        public class MoveLocationMessage : Message
        {
            public MoveLocationMessage(int areaIndex, int coordinateIndex, Coordinate coordinate)
            {
                AreaIndex = areaIndex;
                CoordinateIndex = coordinateIndex;
                Coordinate = coordinate;
            }

            public int AreaIndex { get; }
            public int CoordinateIndex { get; }
            public Coordinate Coordinate { get; }
        }

        public class BeginMoveLocationMessage : Message
        {
            public BeginMoveLocationMessage(int areaIndex, int coordinateIndex)
            {
                AreaIndex = areaIndex;
                CoordinateIndex = coordinateIndex;
            }

            public int AreaIndex { get; }
            public int CoordinateIndex { get; }
        }

        public class EndMoveLocationMessage : Message
        {
            public EndMoveLocationMessage(int areaIndex, int coordinateIndex)
            {
                AreaIndex = areaIndex;
                CoordinateIndex = coordinateIndex;
            }

            public int AreaIndex { get; }
            public int CoordinateIndex { get; }
        }

        public class InsertLocationMessage : Message
        {
            public InsertLocationMessage(int areaIndex, int coordinateIndex, Coordinate coordinate)
            {
                AreaIndex = areaIndex;
                CoordinateIndex = coordinateIndex;
                Coordinate = coordinate;
            }

            public int AreaIndex { get; }
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
