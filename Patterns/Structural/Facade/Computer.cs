using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Computer
    {
        public void WriteHard()
        {
            Console.WriteLine("Write hard");
        }

        public void ReadOS()
        {
            Console.WriteLine("Read Os");
        }

        public void ShowDisplay()
        {
            Console.WriteLine("Show Display");
        }

        public void ResetHard()
        {
            Console.WriteLine("Reset Hard");
        }

        public void CleanRam()
        {
            Console.WriteLine("Clean RAM");
        }

        public void DisableDisplay()
        {
            Console.WriteLine("Disable Display");
        }
    }
}
