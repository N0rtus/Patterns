using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Circle : IShape
    {
        public string Name { get; set; } = nameof(Circle);

        public void GetShapeName()
        {
            Console.WriteLine($"This is {Name}");
        }
    }
}
