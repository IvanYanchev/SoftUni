using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string inputStrings = "a b b b xxxx c c c dd dd";
            string[] elements = inputStrings.Split(' ');

            for (int i = 0; i < elements.Length - 1; i++)
            {
                Console.Write(elements[i]);
                if (elements[i] == elements[i + 1])
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(elements[elements.Length-1]);
        }
    }
}
