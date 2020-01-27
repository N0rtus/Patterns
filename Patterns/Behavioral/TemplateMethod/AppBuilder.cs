using System;

namespace TemplateMethod
{
    public class AppBuilder : Builder
    {
        public override void Deploy()
        {
            Console.WriteLine("Deploy app");
        }

        public override void Test()
        {
            Console.Write("Test app");
        }

        public override void Compile()
        {
            Console.WriteLine("Compile app");
        }
    }
}