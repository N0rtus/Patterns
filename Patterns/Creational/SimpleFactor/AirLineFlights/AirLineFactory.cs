using System;

namespace SimpleFactor.AirLineFlights
{
    public class AirLineFactory
    {
        public static IAirLine Create(AirlineType airline)
        {
            if (airline == AirlineType.Mahan)
            {
                return new MahanAirLine();
            }

            if (airline == AirlineType.Zargros)
            {
                return new ZagrosAirLine();
            }

            throw new NotSupportedException("the airline doesn't support");
        }                   
    }
}