namespace AbstractFactory
{
    public class CharterAirlineFactory : IAirlineFactory
    {
        public IAirline Create()
        {
            return new MahanAirline("43");
        }
    }
}