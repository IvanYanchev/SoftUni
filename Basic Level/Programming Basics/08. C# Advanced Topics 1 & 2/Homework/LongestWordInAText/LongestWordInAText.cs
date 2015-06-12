using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWordInAText
{
    class LongestWordInAText
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' , ',' , '.' }, StringSplitOptions.RemoveEmptyEntries);

            int max = 0;
            int index = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    index = i;
                }
            }
            Console.WriteLine(words[index]);

        }
    }
}
