using System.Collections.Generic;

namespace SimpleFactor.AirLineFlights
{
    public class MahanAirLine : IAirLine
    {
        public List<string> GetFlights()
        {
            return new List<string>
            {
                "Mashhad - Tehran"
            };
        }
    }
}