using System.Collections.Generic;

namespace Strategy
{
    public class Sorter
    {
        private ISortStrategy _sortStrategy;

        public Sorter(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public List<int> Sort(List<int> list)
        {
           return _sortStrategy.Sort(list);
        }
    }
}