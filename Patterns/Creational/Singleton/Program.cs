using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            var loggerOne = LogManager.Instance;
            Console.WriteLine("LoggerOne:");
            loggerOne.Log();

            var loggerTow = LogManager.Instance;
            Console.WriteLine("LoggerTow:");
            loggerTow.Log();


            Console.ReadKey();
        }
    }
}
