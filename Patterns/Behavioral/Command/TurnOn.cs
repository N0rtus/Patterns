using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnOn : ICommand
    {
        public TurnOn(Bulb bulb)
        {
            _bulb = bulb;
        }

        private Bulb _bulb;

        public void Execute()
        {
            _bulb.TurnOn();
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            _bulb.TurnOff();
        }
    }
}
