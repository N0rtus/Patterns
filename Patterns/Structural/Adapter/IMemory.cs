using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IMemory
    {
        void GetData();

        void SetData();

        void Connect();
    }
}
