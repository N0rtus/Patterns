namespace TemplateMethod
{
    public abstract class Builder
    {

        public void Build()
        {
            Compile();
            Test();
            Deploy();
        }

        public abstract void Deploy();
        
        public abstract void Test();

        public abstract void Compile();
    }
}