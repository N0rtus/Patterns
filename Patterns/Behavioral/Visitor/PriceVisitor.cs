using System;

namespace Visitor
{
    public class PriceVisitor : IVisitor
    {
        public void Accept(IStore store)
        {
            var car = store as Car;

            var disCount = 1000;

            Console.WriteLine($"The {car.Name}, price is {car.Price - disCount}");
        }
    }
}