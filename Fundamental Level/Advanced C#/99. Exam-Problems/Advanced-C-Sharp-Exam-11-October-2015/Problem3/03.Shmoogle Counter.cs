using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem3
{
    class Problem3
    {
        static void Main()
        {
            List<string> intVariables = new List<string>();
            List<string> doubleVariables = new List<string>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "//END_OF_CODE")
                {
                    break;
                }

                string pattern = @"(int|double)([[],*])*\s+(\w{1,25})";

                MatchCollection matches = Regex.Matches(inputLine, pattern);

                foreach (Match match in matches)
                {
                    string typeOfVariable = match.Groups[1].Value;
                    string nameOfVariable = match.Groups[3].Value;

                    if (typeOfVariable == "int")
                    {
                        intVariables.Add(nameOfVariable);
                    }
                    else if(typeOfVariable == "double")
                    {
                        doubleVariables.Add(nameOfVariable);
                    }
                }
            }

            doubleVariables.Sort();
            intVariables.Sort();

            PrintResult("Doubles", doubleVariables);
            PrintResult("Ints", intVariables);
        }

        static void PrintResult(string typeOfvariable, List<string> listOfVariables)
        {
            string outputVariables = "None";
            if (listOfVariables.Count > 0)
            {
                outputVariables = string.Join(", ", listOfVariables);
            }
            Console.WriteLine("{0}: {1}", typeOfvariable, outputVariables);
        }
    }
}
