using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string validUsernamePattern = @"\b[a-zA-Z]\w{2,24}\b";

            MatchCollection usernames = Regex.Matches(input, validUsernamePattern);

            int sumMax = int.MinValue;
            int indexFirstUsername = 0;
            for (int i = 0; i < usernames.Count - 1; i++)
            {
                int sum = usernames[i].Length + usernames[i + 1].Length;
                if (sum > sumMax)
                {
                    sumMax = sum;
                    indexFirstUsername = i;
                }
            }
            Console.WriteLine(usernames[indexFirstUsername]);
            Console.WriteLine(usernames[indexFirstUsername + 1]);
        }
    }
}
