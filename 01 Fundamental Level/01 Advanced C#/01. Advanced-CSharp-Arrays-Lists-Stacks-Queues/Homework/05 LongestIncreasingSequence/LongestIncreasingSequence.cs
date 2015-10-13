using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main()
        {
            string input = "10 9 8 7 6 5 4 3 2 1";
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            int lenghtCurrentSeq = 1;
            int lenghtLongestSeq = 1;
            int longestSeqStartingIndex = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                Console.Write(numbers[i]);
                if (numbers[i] < numbers [i + 1])
                {
                    Console.Write(" ");
                    lenghtCurrentSeq++;
                    if (lenghtCurrentSeq > lenghtLongestSeq)
                    {
                        lenghtLongestSeq = lenghtCurrentSeq;
                        longestSeqStartingIndex = i - lenghtCurrentSeq + 2;
                    }
                }
                else
                {
                    Console.WriteLine();
                    lenghtCurrentSeq = 1;
                }
            }

            Console.WriteLine(numbers[numbers.Length - 1]);

            Console.Write("Longest: ");
            for (int i = longestSeqStartingIndex; i < longestSeqStartingIndex + lenghtLongestSeq; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
