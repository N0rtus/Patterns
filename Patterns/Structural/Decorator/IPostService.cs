using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface IPostService
    {
        IPostRepository PostRepository { get; set; }

        void Create(string post);
    }
}
        