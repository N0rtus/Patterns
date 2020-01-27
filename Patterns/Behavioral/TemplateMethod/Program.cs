using System;

namespace TemplateMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var appBuilder = new AppBuilder();
            
            appBuilder.Build();
            
            var iosAppBuilder = new IosAppBuilder();
            
            iosAppBuilder.Build();
            
            Console.ReadKey();
        }
    }
}