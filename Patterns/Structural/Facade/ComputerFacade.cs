using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ComputerFacade
    {
        public ComputerFacade(Computer computer)
        {
            _computer = computer;
        }

        private Computer _computer;

        public void TurnOn()
        {
            _computer.WriteHard();
            _computer.ReadOS();
            _computer.ShowDisplay();
        }

        public void TurnOff()
        {
            _computer.ResetHard();
            _computer.CleanRam();
            _computer.DisableDisplay();
        }
    }
}
