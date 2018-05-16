using FluentAssertions;
using System.Numerics;
using Wpf.Elmish.Sample.Utils;
using Xunit;

namespace Wpf.Elmish.Test
{
    public class VectorTest
    {
        [Fact]
        public void DistanceFromPointToLineShouldWork()
        {
            new Vector2(2, 3)
                .GetNearestPointAt(new Vector2(0, 5))
                .Should()
                .Be(new Vector2(0, 3));
        }
    }
}
