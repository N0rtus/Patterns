using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Strategy
{
    public class BubbleSort : ISortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Sort by BubbleSort");

            return list;
        }
    }
}