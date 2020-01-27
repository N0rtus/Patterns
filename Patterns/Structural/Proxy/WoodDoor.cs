using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class WoodDoor : IDoor
    {
        public void Close()
        {
            Console.WriteLine("The door has closed");
        }

        public void Open()
        {
            Console.WriteLine("The door has opned");
        }
    }
}
