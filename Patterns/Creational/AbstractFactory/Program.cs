using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            IAirlineFactory charterAirlineFactory = new CharterAirlineFactory();

            var charterAirline = charterAirlineFactory.Create();

            var charterFlights = charterAirline.GetFlights();

            Console.WriteLine("charter flights:");
            foreach (var flight in charterFlights)
            {
                Console.WriteLine(flight);
            }


            IAirlineFactory systematicAirlineFactory = new SystematicAirlineFactory();

            var systematicAirline = systematicAirlineFactory.Create();

            var systematicFlights = systematicAirline.GetFlights();

            Console.WriteLine("systematic flights:");
            foreach (var flight in systematicFlights)
            {
                Console.WriteLine(flight);
            }


            Console.ReadKey();
        }
    }
}
