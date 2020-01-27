using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SecuredDoor
    {
        private IDoor _door;

        public SecuredDoor(IDoor door)
        {
            _door = door;
        }

        public void Open(string key)
        {
            if (key == "correct_key")
            {
                _door.Open();
            }

            Console.WriteLine("The key is incorrect");
        }

        public void Close()
        {
            _door.Close();
        }
    }   
}
