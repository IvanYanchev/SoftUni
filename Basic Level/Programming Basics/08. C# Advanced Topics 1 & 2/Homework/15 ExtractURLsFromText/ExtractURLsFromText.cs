using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main(string[] args)
        {
            string input = "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";
            string[] inputWords = input.Split(' ');
            foreach (var word in inputWords)
            {
                if (word.StartsWith("www") || word.StartsWith("http"))
                {
                    Console.WriteLine(word.TrimEnd('.'));
                }
            }
        }
    }
}
