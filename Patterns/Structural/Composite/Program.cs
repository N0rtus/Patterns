using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var org = new Orgranization();

            org.AddEmployee(new Developer());

            org.AddEmployee(new Designer());

            Console.WriteLine("Organization salaries");

            foreach (var item in org.GetEmployees())
            {
                Console.WriteLine($"{item.JobTitle}-{item.GetSalary()}");
            }

            Console.ReadKey();
        }
    }
}
