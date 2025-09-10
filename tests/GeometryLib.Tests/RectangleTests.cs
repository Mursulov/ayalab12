using System;
using Xunit;
using GeometryLib;

namespace GeometryLib.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void Area_CalculatedCorrectly()
        {
            var rect = new Rectangle(3.0, 4.0);
            Assert.Equal(12.0, rect.Area, 6);
        }

        [Fact]
        public void Perimeter_CalculatedCorrectly()
        {
            var rect = new Rectangle(3.0, 4.0);
            Assert.Equal(14.0, rect.Perimeter, 6);
        }

        [Fact]
        public void Constructor_Throws_ForNonPositiveSides()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(0, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(1, -2));
        }
    }
}
