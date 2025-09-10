using System;
using System.Collections.Generic;

namespace GeometryLib
{
    public class Figure
    {
        private readonly List<Point> points;

        public string Name { get; set; } = "Figure";

        private Figure(params Point[] pts)
        {
            if (pts == null) throw new ArgumentNullException(nameof(pts));
            if (pts.Length < 3 || pts.Length > 5) throw new ArgumentException("Figure must have between 3 and 5 points.");
            points = new List<Point>(pts);
        }

        public Figure(Point a, Point b, Point c) : this(new[] { a, b, c }) { }

        public Figure(Point a, Point b, Point c, Point d) : this(new[] { a, b, c, d }) { }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(new[] { a, b, c, d, e }) { }

        public double LengthSide(Point A, Point B)
        {
            if (A == null || B == null) throw new ArgumentNullException();
            double dx = A.X - B.X;
            double dy = A.Y - B.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                var current = points[i];
                var next = points[(i + 1) % points.Count];
                sum += LengthSide(current, next);
            }
            return sum;
        }
    }
}
