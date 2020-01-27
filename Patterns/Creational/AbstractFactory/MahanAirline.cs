using System.Collections.Generic;

namespace AbstractFactory
{
    public class MahanAirline : IAirline
    {
        public MahanAirline(string agencyCode)
        {
            AgencyCode = agencyCode;
        }

        public string AgencyCode { get; set; }

        public List<string> GetFlights()
        {
            return new List<string>
           {
               $"Tehran-Mashhad-{AgencyCode}"  ,
               $"Kish-Ahvaz-{AgencyCode}"  ,

           };
        }
    }
}