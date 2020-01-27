using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CameraMemory : IMemory
    {
        public void GetData()
        {
            Console.WriteLine("faset getting data");

        }

        public void SetData()
        {
            Console.WriteLine("faset sending data");
        }

        public void Connect()
        {
            Console.WriteLine("connected");

            GetData();
            SetData();
        }
    }
}
