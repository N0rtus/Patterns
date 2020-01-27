using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnOff : ICommand
    {
        public TurnOff(Bulb bulb)
        {
            _bulb = bulb;
        }
            
        private Bulb _bulb;

        public void Execute()
        {
            _bulb.TurnOff();
        }

        public void Redo()
        {
            Execute();
        }

        public void Undo()
        {
            _bulb.TurnOn();
        }
    }
}
