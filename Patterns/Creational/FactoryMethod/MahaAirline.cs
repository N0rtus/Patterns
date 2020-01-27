using System.Collections.Generic;

namespace FactoryMethod
{
    public class MahaAirline : IAireline
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Rasht-Shiraz",
                "Tehran-Ahvaz"
            };
        }
    }
}