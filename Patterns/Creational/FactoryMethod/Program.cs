using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            IAirlineFactory airlineFactory = new AirlineFactory();

            var defaultAirline = airlineFactory.Create();

            var mahanAirline = airlineFactory.Create("Mahan");

            var flights = defaultAirline.GetFlights();

            flights.AddRange(mahanAirline.GetFlights());

            Console.WriteLine($"airline flihgts:");

            foreach (var flight in flights)
            {
                Console.WriteLine(flight);
            }

            Console.ReadKey();
        }
    }
}
