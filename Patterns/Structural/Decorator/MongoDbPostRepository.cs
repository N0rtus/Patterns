using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MongoDbPostRepository : IPostRepository
    {
        public void Create(string post)
        {
            Console.WriteLine($"the {post} has created in mongodb");
        }
    }
}
