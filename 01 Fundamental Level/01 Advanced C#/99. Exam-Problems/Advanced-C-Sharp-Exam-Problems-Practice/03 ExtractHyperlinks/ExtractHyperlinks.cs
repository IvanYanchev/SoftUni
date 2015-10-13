using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractHyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            StringBuilder htmlInput = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                htmlInput.Append(input);
            }

            string html = htmlInput.ToString();
            string aTagPattern = @"<a(.+?)<\/a>";

            MatchCollection elements = Regex.Matches(html, aTagPattern);

            foreach (Match element in elements)
            {
                string hrefPattern = @"href\s*=\s*(['""]?)(.+?)(\1)";
                Match match = Regex.Match(element.Value, hrefPattern);
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
