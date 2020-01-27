using System;

namespace FactoryMethod
{
    public class AirlineFactory : IAirlineFactory
    {
        public IAireline Create()
        {
            return new ZagrosAirline();
        }

        public IAireline Create(string airLine)
        {
            if (airLine == "Zagros")
            {
                return new ZagrosAirline();
            }

            if (airLine == "Mahan")
            {
                return new MahaAirline();
            }

            throw new NotSupportedException("the airLine doesn't support");
        }
    }
}