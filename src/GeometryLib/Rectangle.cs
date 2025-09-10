using System;

namespace GeometryLib
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double sideA, double sideB)
        {
            if (sideA <= 0) throw new ArgumentOutOfRangeException(nameof(sideA), "Side must be positive.");
            if (sideB <= 0) throw new ArgumentOutOfRangeException(nameof(sideB), "Side must be positive.");

            this.sideA = sideA;
            this.sideB = sideB;
        }

        private double CalculateArea() => sideA * sideB;

        private double CalculatePerimeter() => 2 * (sideA + sideB);

        public double Area => CalculateArea();

        public double Perimeter => CalculatePerimeter();
    }
}
