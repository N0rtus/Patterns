using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Regtangle : IShape
    {
        public string Name { get; set; } = nameof(Regtangle);

        public void GetShapeName()
        {
            Console.WriteLine($"This is {Name}");
        }
    }
}
    