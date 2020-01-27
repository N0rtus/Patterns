using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulb = new Bulb();

            var turnOn = new TurnOn(bulb);

            var turnOff = new TurnOff(bulb);

            var remote = new RemoteControl();

            remote.Submit(turnOn);

            remote.Submit(turnOff);

            turnOff.Undo();

            turnOn.Redo();

            Console.ReadKey();
        }
    }
}
