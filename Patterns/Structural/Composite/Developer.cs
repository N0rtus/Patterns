using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Developer : IEmployee
    {
        public string JobTitle { get; set; } = nameof(Developer);

        public int GetSalary()
        {
            return 5000;    
        }
    }
}
