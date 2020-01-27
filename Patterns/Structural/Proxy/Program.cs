using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            var door = new SecuredDoor(new WoodDoor());

            Console.WriteLine("Now open the door");
            door.Open("correct_key");

            Console.WriteLine("\n");

            Console.WriteLine("Now close the door");
            door.Close();

            Console.ReadKey();
        }
    }
}
