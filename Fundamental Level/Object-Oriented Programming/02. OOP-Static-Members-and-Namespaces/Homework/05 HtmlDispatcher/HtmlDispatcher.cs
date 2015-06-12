using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlDispatcher
{
    class HtmlDispatcher
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
  
            div.AddAtribute("id", "page");
            div.AddAtribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div * 3);
        }
    }
}
