using System;
using System.Collections.Generic;
using GeometryLib;

class Program
{
    static void Main()
    {
        PrintCtsMinMax();

        Console.WriteLine("\n--- Rectangle ---");
        Console.Write("Enter side A (double): ");
        if (!double.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Invalid input for side A.");
            return;
        }

        Console.Write("Enter side B (double): ");
        if (!double.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Invalid input for side B.");
            return;
        }

        var rect = new Rectangle(a, b);
        Console.WriteLine($"Area: {rect.Area}");
        Console.WriteLine($"Perimeter: {rect.Perimeter}");

        Console.WriteLine("\n--- Figure ---");
        Console.Write("How many points (3-5)? ");
        if (!int.TryParse(Console.ReadLine(), out var n) || n < 3 || n > 5)
        {
            Console.WriteLine("Invalid number of points.");
            return;
        }

        var points = new List<Point>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Point #{i + 1}:");
            Console.Write("  X (int): ");
            if (!int.TryParse(Console.ReadLine(), out var x))
            {
                Console.WriteLine("Invalid X.");
                return;
            }
            Console.Write("  Y (int): ");
            if (!int.TryParse(Console.ReadLine(), out var y))
            {
                Console.WriteLine("Invalid Y.");
                return;
            }
            points.Add(new Point(x, y));
        }

        Figure fig = n switch
        {
            3 => new Figure(points[0], points[1], points[2]) { Name = $"Triangle_{DateTime.Now:yyyyMMddHHmmss}" },
            4 => new Figure(points[0], points[1], points[2], points[3]) { Name = $"Quad_{DateTime.Now:yyyyMMddHHmmss}" },
            5 => new Figure(points[0], points[1], points[2], points[3], points[4]) { Name = $"Pentagon_{DateTime.Now:yyyyMMddHHmmss}" },
            _ => throw new InvalidOperationException()
        };

        Console.WriteLine($"Figure name: {fig.Name}");
        Console.WriteLine($"Perimeter: {fig.PerimeterCalculator():F4}");
    }

    static void PrintCtsMinMax()
    {
        Console.WriteLine("--- CTS predefined types min/max ---");
        Console.WriteLine($"sbyte: {sbyte.MinValue} .. {sbyte.MaxValue}");
        Console.WriteLine($"byte: {byte.MinValue} .. {byte.MaxValue}");
        Console.WriteLine($"short: {short.MinValue} .. {short.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue} .. {ushort.MaxValue}");
        Console.WriteLine($"int: {int.MinValue} .. {int.MaxValue}");
        Console.WriteLine($"uint: {uint.MinValue} .. {uint.MaxValue}");
        Console.WriteLine($"long: {long.MinValue} .. {long.MaxValue}");
        Console.WriteLine($"ulong: {ulong.MinValue} .. {ulong.MaxValue}");
        Console.WriteLine($"float: {float.MinValue} .. {float.MaxValue}");
        Console.WriteLine($"double: {double.MinValue} .. {double.MaxValue}");
        Console.WriteLine($"decimal: {decimal.MinValue} .. {decimal.MaxValue}");
        Console.WriteLine($"char: {(int)char.MinValue} .. {(int)char.MaxValue} (numeric code points)");
    }
}
