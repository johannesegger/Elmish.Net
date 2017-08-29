using OneOf;

namespace Wpf.NoXaml
{
    public abstract class Message : OneOfBase<Message.MoveLocationMessage>
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
    }
}
