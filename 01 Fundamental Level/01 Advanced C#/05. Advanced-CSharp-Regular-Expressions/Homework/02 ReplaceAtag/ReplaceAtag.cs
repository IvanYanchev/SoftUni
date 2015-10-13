using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace ReplaceAtag
{
    class ReplaceAtag
    {
        static void Main(string[] args)
        {
            //string input = File.ReadAllText("../../ahref.html");

            string input = "<a href=http://softuni.bg>SoftUni</a>";

            string pattern = @"<a(\s\w+=\w+:\/\/\w+\.\w+)>(\w+)<\/a>";

            string replacement = @"[URL$1]$2[/URL]";

            string output = Regex.Replace(input, pattern, replacement);

            //File.WriteAllText("../../URLhref.html", output);

            Console.WriteLine(output);
        }
    }
}
