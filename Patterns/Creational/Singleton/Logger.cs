using System;

namespace Singleton
{
    public class Logger
    {
        private string _key = Guid.NewGuid().ToString("N");

        public void Log()
        {
           Console.WriteLine($"Key:{_key}");
           Console.WriteLine($"This is singleton pattern \n");
        }
    }
}