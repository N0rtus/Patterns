using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebPage aboutPage = new About(new DarkTheme());
            IWebPage projectPage = new Projects(new LightTheme());

            Console.WriteLine("This is about page:");
            aboutPage.GetContent();

            Console.WriteLine("\n");

            Console.WriteLine("This is project page:");
            projectPage.GetContent();

            Console.ReadKey();
        }
    }
}
