using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QueryMess
{
    class QueryMess
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                string inputText = Console.ReadLine();
                if (inputText == "END")
                {
                    break;
                }

                // find and replace spaces
                string spacePattern = @"%20|\+";
                inputText = Regex.Replace(inputText, spacePattern, " ");
                string multipleWhitespacePattern = @"\s+";
                inputText = Regex.Replace(inputText, multipleWhitespacePattern, " ");

                // find all pairs key=value in the current input line
                string pairPattern = @"([^=&?]+)=([^=&?]+)";
                MatchCollection pairs = Regex.Matches(inputText, pairPattern);

                foreach (Match pair in pairs)
                {
                    string key = pair.Groups[1].Value.Trim();
                    string value = pair.Groups[2].Value.Trim();

                    if (dict.ContainsKey(key))
                    {
                        dict[key].Add(value);
                    }
                    else
                    {
                        dict.Add(key, new List<string>() { value });
                    }
                }

                foreach (var list in dict)
                {
                    Console.Write("{0}=[{1}]", list.Key, string.Join(", ", list.Value));
                }
                Console.WriteLine();
            }
        }
    }
}