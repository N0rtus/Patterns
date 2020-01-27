using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();

            var soheil = new User("Soheil", chatRoom);
            var ali = new User("Ali", chatRoom);

            soheil.SendMessage("Hello from vs");

            ali.SendMessage("Hello from rider IDE");

            Console.ReadKey();
        }
    }
}