using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Array_Matcher
{
    class ArrayMatcher
    {
        static void Main(string[] args)
        {
            string commandLine = Console.ReadLine();
            string[] commandArguments = commandLine.Split('\\');

            List<char> resultArray = new List<char>();

            switch (commandArguments[2])
            {
                case "join":
                    {
                        resultArray = Join(commandArguments[0], commandArguments[1]);
                        break;
                    }
                case "right exclude":
                    {
                        resultArray = Exclude(commandArguments[0], commandArguments[1]);
                        break;
                    }
                case "left exclude":
                    {
                        resultArray = Exclude(commandArguments[1], commandArguments[0]);
                        break;
                    }
            }

            resultArray.Sort();

            Console.WriteLine(string.Join("", resultArray));
        }

        static List<char> Join(string leftArr, string rightArr)
        {

            List<char> resultArr = new List<char>();

            foreach (var letter in leftArr)
            {
                if (rightArr.Contains(letter))
                {
                    resultArr.Add(letter);
                }
            }

            return resultArr;
        }

        static List<char> Exclude(string leftArr, string rightArr)
        {
            List<char> resultArr = new List<char>();

            foreach (var letter in leftArr)
            {
                if (!rightArr.Contains(letter))
                {
                    resultArr.Add(letter);
                }
            }

            return resultArr;
        }
    }
}
