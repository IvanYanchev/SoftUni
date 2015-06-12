using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BiggestTableRow
{
    class BiggestTableRow
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            // Input from console
            List<string> table = new List<string>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                table.Add(inputLine);
                if (inputLine == "</table>")
                {
                    break;
                }
            }

            Dictionary<string, List<string>> towns = new Dictionary<string, List<string>>();
            double? sumMax = null;
            string townMax = null;

            string regexPattern = @"<td>(.+?)<\/td>";

            for (int indexRow = 2; indexRow < table.Count - 1; indexRow++)
            {
                MatchCollection matches = Regex.Matches(table[indexRow], regexPattern);

                towns.Add(matches[0].Groups[1].Value, new List<string>());

                double? sumStoresTownX = null;
                
                for (int x = 1; x <= 3; x++)
                {
                    double storeX = 0;
                    bool isParsable = double.TryParse(matches[x].Groups[1].Value, out storeX);
                    if (isParsable)
                    {
                        towns[matches[0].Groups[1].Value].Add(matches[x].Groups[1].Value);
                        if (sumStoresTownX == null)
                        {
                            sumStoresTownX = storeX;
                        }
                        else
                        {
                            sumStoresTownX += storeX;
                        }
                    }
                }

                if ((sumStoresTownX != null && sumMax == null) ||
                    (sumStoresTownX != null && sumMax != null && sumStoresTownX > sumMax))
                {
                    sumMax = sumStoresTownX;
                    townMax = matches[0].Groups[1].Value;
                }
            }

            if (sumMax == null)
            {
                Console.WriteLine("no data");
            }
            else
            {
                Console.WriteLine("{0} = {1}", sumMax, string.Join(" + ", towns[townMax]));
            }
        }
    }
}
