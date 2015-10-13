using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JumpingSums
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int[] sums = new int[numbers.Length];

            int numberOfJumps = int.Parse(Console.ReadLine());

            for (int index = 0; index < numbers.Length; index++)
            {
                sums[index] = numbers[index];
                int currentIndex = index;
                for (int j = 0; j < numberOfJumps; j++)
                {
                    int nextIndex = currentIndex + numbers[currentIndex];
                    if (nextIndex >= numbers.Length)
                    {
                        nextIndex = nextIndex % numbers.Length;
                    }
                    sums[index] += numbers[nextIndex];
                    currentIndex = nextIndex;
                }
            }

            Console.WriteLine("max sum = {0}", sums.Max());
        }
    }
}
