using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SDCardMemoryAdapter : IMemory
    {
        private SDCardMemory _memory;

        public SDCardMemoryAdapter()
        {
            _memory = new SDCardMemory();
        }

        public void Connect()
        {
            _memory.ConnectToDevice();
        }

        public void GetData()
        {
            _memory.ReadData();
        }

        public void SetData()
        {
            _memory.SendData();
        }
    }
}
