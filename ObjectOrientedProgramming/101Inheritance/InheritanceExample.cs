using System;

namespace OOP.Inheritance
{
    public static class InheritanceExample
    {
        public static void Execute()
        {
            Shape[] shapes = { new Rectangle(10, 12), new Square(5),
                        new Circle(3) };
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape}: area, {Shape.GetArea(shape)}; " +
                                  $"perimeter, {Shape.GetPerimeter(shape)}");
                var rect = shape as Rectangle;
                if (rect != null)
                {
                    Console.WriteLine($"   Is Square: {rect.IsSquare()}, Diagonal: {rect.Diagonal}");
                    continue;
                }
                var sq = shape as Square;
                if (sq != null)
                {
                    Console.WriteLine($"   Diagonal: {sq.Diagonal}");
                    continue;
                }
            }
        }

        public class Square : Shape
        {
            public Square(double length)
            {
                Side = length;
            }

            public double Side { get; }

            public override double Area => Math.Pow(Side, 2);

            public override double Perimeter => Side * 4;

            public double Diagonal => Math.Round(Math.Sqrt(2) * Side, 2);
        }

        public class Rectangle : Shape
        {
            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public double Length { get; }

            public double Width { get; }

            public override double Area => Length * Width;

            public override double Perimeter => 2 * Length + 2 * Width;

            public bool IsSquare() => Length == Width;

            public double Diagonal => Math.Round(Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2)), 2);
        }

        public class Circle : Shape
        {
            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

            public override double Perimeter => Math.Round(Math.PI * 2 * Radius, 2);

            // Define a circumference, since it's the more familiar term.
            public double Circumference => Perimeter;

            public double Radius { get; }

            public double Diameter => Radius * 2;
        }

    }
}
