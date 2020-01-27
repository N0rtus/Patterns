namespace AbstractFactory
{
    public class SystematicAirlineFactory : IAirlineFactory
    {
        public IAirline Create()
        {
            return new ZagrosAirline();
        }
    }
}