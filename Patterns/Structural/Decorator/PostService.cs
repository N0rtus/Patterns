using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PostService : IPostService
    {
        public PostService(IPostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        public IPostRepository PostRepository { get; set; }

        public void Create(string post)
        {
            Console.WriteLine("Service Create post has called");
            PostRepository.Create(post);
        }
    }
}
