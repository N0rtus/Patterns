using System.Collections.Generic;
using System.Threading.Tasks;

namespace Strategy
{
    public interface ISortStrategy
    {
        List<int> Sort(List<int> list);
    }
}    