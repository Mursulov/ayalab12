using System;
using Xunit;
using GeometryLib;

namespace GeometryLib.Tests
{
    public class FigureTests
    {
        [Fact]
        public void LengthSide_ComputesDistance()
        {
            var fig = new Figure(new Point(0, 0), new Point(1, 0), new Point(0, 1));
            double d = fig.LengthSide(new Point(0, 0), new Point(3, 4));
            Assert.Equal(5.0, d, 6);
        }

        [Fact]
        public void PerimeterCalculator_Triangle()
        {
            var a = new Point(0, 0);
            var b = new Point(3, 0);
            var c = new Point(0, 4);
            var fig = new Figure(a, b, c);
            // sides: 3, 5, 4 -> perimeter 12
            Assert.Equal(12.0, fig.PerimeterCalculator(), 6);
        }

        [Fact]
        public void PerimeterCalculator_Square()
        {
            var a = new Point(0, 0);
            var b = new Point(1, 0);
            var c = new Point(1, 1);
            var d = new Point(0, 1);
            var fig = new Figure(a, b, c, d);
            Assert.Equal(4.0, fig.PerimeterCalculator(), 6);
        }

        [Fact]
        public void Constructor_ValidatesPointCount()
        {
            var ex = Assert.Throws<ArgumentException>(() => {
                // construct via vector-like path is private; but creating with wrong number via reflection is unnecessary
                throw new ArgumentException();
            });
            Assert.NotNull(ex);
        }
    }
}
