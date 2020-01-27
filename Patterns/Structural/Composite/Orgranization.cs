using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Orgranization
    {
        private List<IEmployee> Employees { get; set; } = new List<IEmployee>();

        public void AddEmployee(IEmployee employee)
        {
            Employees.Add(employee);
        }

        public List<IEmployee> GetEmployees()
        {
            return Employees;
        }
    }
}   
