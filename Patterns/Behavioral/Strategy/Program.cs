using System;
using System.Linq;

namespace Strategy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new[] {1, 2, 3};
            
            var qSorter = new Sorter(new QuickSort());

            qSorter.Sort(list.ToList());
            
            var bSorter = new Sorter(new BubbleSort());

            bSorter.Sort(list.ToList());

            Console.ReadKey();
        }
    }
}