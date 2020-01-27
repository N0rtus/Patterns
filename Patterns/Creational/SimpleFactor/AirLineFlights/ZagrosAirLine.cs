using System.Collections.Generic;

namespace SimpleFactor.AirLineFlights
{
    public class ZagrosAirLine : IAirLine
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Mashhad - Kish"
            };
        }
    }
}