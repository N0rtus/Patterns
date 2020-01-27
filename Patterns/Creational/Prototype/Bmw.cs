namespace Prototype
{
    public class Bmw : ICar
    {
        public Bmw(string model)
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