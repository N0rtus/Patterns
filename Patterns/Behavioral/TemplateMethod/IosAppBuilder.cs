using System;

namespace TemplateMethod
{
    public class IosAppBuilder : Builder
    {
        public override void Deploy()
        {
            Console.WriteLine("Deploy iOS App");
        }

        public override void Test()
        {
            Console.WriteLine("Test iOS App");
        }

        public override void Compile()
        {
            Console.WriteLine("Compile iOS App");
        }
    }
}