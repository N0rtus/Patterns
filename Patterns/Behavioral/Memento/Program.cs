using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();

            editor.Type("This is 1");
            editor.Type("This is 2");

            Console.WriteLine(editor.Content);

            editor.Save();

            editor.Type("This is 3");

            Console.WriteLine(editor.Content);

            editor.Restore();

            Console.WriteLine(editor.Content);

            Console.ReadKey();
        }
    }
}
