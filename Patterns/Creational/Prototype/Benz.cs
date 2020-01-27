namespace Prototype
{
    public class Benz : ICar
    {
        public Benz(string model)
        {
            this.Model = model;
        }

        public string Model { get; set; }

        public ICar Clone()
        {
            return this.MemberwiseClone() as ICar;
        }
    }
}