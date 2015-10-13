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
            while (true)
            {
                string inputText = Console.ReadLine();
                if (inputText == "END")
                {
                    break;
                }

                //string hRefPattern = @"<a\n*.*\t*\shref.*\n*\t*=.*\n*\t*(['""])(.+)\1.+<\/a>";
                string hRefPattern = @"<a.*href=(['""])(\S+)\1.+<\/a>";

                MatchCollection hrefs = Regex.Matches(inputText, hRefPattern);
                
                foreach (Match href in hrefs)
                {
                    Console.WriteLine(href.Groups[2]);
                }
            }
        }
    }
}
