using System.Collections.Generic;

namespace FactoryMethod
{
    public class ZagrosAirline : IAireline
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Tehran-Mashhad",
                "Kish-Ahvaz"
            };
        }
    }
}