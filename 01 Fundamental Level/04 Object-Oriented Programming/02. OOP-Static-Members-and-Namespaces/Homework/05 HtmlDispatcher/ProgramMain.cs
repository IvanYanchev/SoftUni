using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlDispatcher
{
    class ProgramMain
    {
        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");

            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div * 2);

            Console.WriteLine(HtmlDispatcher.CreateImage("http://nvlmbvR1So1usi9s5o1_1280.jpg", "I’ve got some bad news about giraffes.", "Giraffes"));
            
        }
    }
}
