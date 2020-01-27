namespace FactoryMethod
{
    public interface IAirlineFactory
    {
        IAireline Create();

        IAireline Create(string airLine);
    }
}                                       