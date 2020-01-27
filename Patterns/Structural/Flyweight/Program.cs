using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ShapeFactory();

            var shape = factory.GetShape(nameof(Circle));

            shape.GetShapeName();

            shape = factory.GetShape(nameof(Circle));

            shape.GetShapeName();

            shape = factory.GetShape(nameof(Regtangle));

            shape.GetShapeName();

            shape = factory.GetShape(nameof(Regtangle));

            shape.GetShapeName();

            Console.WriteLine($"The total object count: {factory.ShapesCount}");

            Console.ReadKey();
        }
    }
}
