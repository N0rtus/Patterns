using System;
using System.Linq;

namespace Iterator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stations = new StationList();
            
            stations.Add(new RadioStation(77));
            
            stations.Add(new RadioStation(49));

            var frecancy77 = stations.First(x => x.GetFrencancy() == 77);

            Console.WriteLine("The Stations is:" + frecancy77.GetFrencancy());
            Console.ReadKey();
        }
    }
}