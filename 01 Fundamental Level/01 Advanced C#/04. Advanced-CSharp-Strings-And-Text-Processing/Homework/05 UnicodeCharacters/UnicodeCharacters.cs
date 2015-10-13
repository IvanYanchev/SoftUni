using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder hexString = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                hexString.Append("\\u");
                hexString.Append(((int)input[i]).ToString("X4"));
            }

            string output = hexString.ToString();

            Console.WriteLine(output);
        }
    }
}
