using System;
using System.Threading;

namespace Singleton
{
    public class LogManager
    {
        private static Lazy<Logger> _lazyLogger = 
            new Lazy<Logger>(CreateLogger,LazyThreadSafetyMode.ExecutionAndPublication);


        private LogManager()
        {
        }

        public static Logger Instance
        {
            get { return _lazyLogger.Value; }
        }


        private static Logger CreateLogger()
        {
             return new Logger();
        }
    }
}