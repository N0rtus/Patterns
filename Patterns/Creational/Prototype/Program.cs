using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar benz = new Benz("S500");

            var clonedBenz = benz.Clone();


            ICar bmw = new Bmw("XYZ");

            var clonedBmw = bmw.Clone();


            Console.WriteLine("Benz.Model:" + benz.Model);
            Console.WriteLine("Benz.Cloned.Model:" + clonedBenz.Model);

            Console.WriteLine("BMW.Model:" + bmw.Model);
            Console.WriteLine("BMW.Cloned.Model:" + clonedBmw.Model);


            Console.ReadKey();
        }
    }
}
