using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSequence
{
    class LongestIncreasingSequence
    {
        static void Main(string[] args)
        {
            string input = "5 -1 10 20 3 4";
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            int lenghtCurrentSeq = 1;
            int lenghtLongestSeq = int.MinValue;
            int seqStartingIndex = 0;

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
                        seqStartingIndex = i - lenghtCurrentSeq + 2;
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
            if (lenghtLongestSeq == int.MinValue)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = seqStartingIndex; i < seqStartingIndex + lenghtLongestSeq; i++)
                {
                    Console.Write("{0} ", numbers[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
