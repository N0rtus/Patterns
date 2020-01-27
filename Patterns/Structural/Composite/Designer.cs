using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Designer : IEmployee
    {
        public string JobTitle { get; set; } = nameof(Designer);

        public int GetSalary()
        {
            return 4000;
        }
    }
}
