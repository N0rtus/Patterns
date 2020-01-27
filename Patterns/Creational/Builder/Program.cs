using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
             IHtmlDocumentBuilder htmlDocumentBuilder = new HtmlDocumentBuilder();

             var htmlDocument = htmlDocumentBuilder
                 .SetTitle("Design Patterns")
                 .SetHead("This is head")
                 .SetBody("This body")
                 .SetFooter("This is footer")
                 .Build();


             var htmlString = htmlDocument.ToString();

             Console.WriteLine(htmlString);

             Console.ReadKey();
        }
    }
}
