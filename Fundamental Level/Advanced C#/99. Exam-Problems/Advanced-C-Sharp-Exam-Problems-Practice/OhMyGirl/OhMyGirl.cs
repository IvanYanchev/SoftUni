using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OhMyGirl
{
    class OhMyGirl
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = string.Empty;
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                text += inputLine;
            }

            string pattern = "";
            for (int i = 0; i < key.Length; i++)
            {
                char ch = key[i];
                if (ch == '.' || ch == '+' || ch == '*' || ch == '?' || ch == '\\' || ch == '(' || ch == ')' || ch == '[' || ch == ']')
                {
                    pattern += @"\" + ch;
                }
                else if (i == 0 || i == key.Length - 1 || !char.IsLetterOrDigit(ch))
                {
                    pattern += ch;
                }
                else if (char.IsDigit(ch))
                {
                    pattern += @"\d*";
                }
                else if (char.IsLower(ch))
                {
                    pattern += @"[a-z]*";
                }
                else if (char.IsUpper(ch))
                {
                    pattern += @"[A-Z]*";
                }
            }
            pattern = string.Format("({0})({1})({0})", pattern, @".{2,6}");

            MatchCollection matches = Regex.Matches(text, pattern);

            Console.WriteLine(string.Join("", matches.Cast<Match>().Select(x => x.Groups[2].Value).ToList()));
        }
    }
}
