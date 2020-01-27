using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlRepository = new SqlServerPostRepository();

            IPostService postService = new PostService(sqlRepository);

            postService.Create("how to use decorator");

            var monogoDbRepository = new MongoDbPostRepository();

            IPostService noqSqlPostService = new PostService(monogoDbRepository);

            noqSqlPostService.Create("how to use decorator");

            Console.ReadKey();
        }
    }
}
