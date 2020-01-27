using System;

namespace Visitor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IStore car = new Car
            {
                Name = "BMW",
                Price = 2000000
            };    

            car.Visit(new PriceVisitor());
            
            Console.ReadKey();
        }
    }
}