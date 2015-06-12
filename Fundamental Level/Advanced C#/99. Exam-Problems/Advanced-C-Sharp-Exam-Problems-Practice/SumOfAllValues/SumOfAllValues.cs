//You are given a keys string and a text string. Write a program that finds the start key and the end key from the keys string and then applies them to the text string.
//The start key will always stay at the beginning of the keys string. It can contain only letters and underscore and ends just before the first found digit.
//The end key will always stay at the end of the keys string. It can contain only letters and underscore and starts just after the last found digit.
//Print at the console the sum of all values (only floating-point numbers with dot as a separator are considered valid) in the text string, between a start key and an end key. If the value is 0 then print “The total value is: nothing”. If no start key or no end key is found then print “A key is missing”.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SumOfAllValues
{
    class SumOfAllValues
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InstalledUICulture;

            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();

            double result = 0d;

            string keysPattern = @"(^[A-Za-z_]+)\d.*\d([A-Za-z_]+$)";
            Match keys = Regex.Match(keyString, keysPattern);

            if (!keys.Groups[1].Success || !keys.Groups[2].Success)
            {
                Console.WriteLine("<p>A key is missing</p>");
                return;
            }

            string valuePattern = string.Format("{0}(.*?){1}", keys.Groups[1].Value, keys.Groups[2].Value);
            MatchCollection values = Regex.Matches(textString, valuePattern);
            foreach (Match match in values)
            {
                double value = 0d;
                if (double.TryParse(match.Groups[1].Value, out value))
                {
                    result += value;
                }
            }

            if (result == 0)
            {
                Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
            }
            else
            {
                Console.WriteLine("<p>The total value is: <em>{0}</em></p>", result);
            }
        }
    }
}
