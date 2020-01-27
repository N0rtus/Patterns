using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class About : IWebPage
    {
        public About(ITheme theme)
        {
            Theme = theme;
        }

        public ITheme Theme { get; set; }

        public void GetContent()
        {
            Console.WriteLine($"this page content has {Theme.SetColor()}");
        }
    }
}
    