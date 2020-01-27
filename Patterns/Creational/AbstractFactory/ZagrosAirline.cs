using System.Collections.Generic;

namespace AbstractFactory
{
    public class ZagrosAirline : IAirline
    {
        public List<string> GetFlights()
        {
           return new List<string>
           {
               "Tehran-mashahd"
           };
        }
    }
}