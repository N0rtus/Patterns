using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SDCardMemory
    {
        public void ReadData()
        {
            Console.WriteLine("getting data");
        }

        public void SendData()
        {
            Console.WriteLine("sending data");
        }

        public void ConnectToDevice()
        {
            Console.WriteLine("connected");

            SendData();
            ReadData();
        }
    }
}
