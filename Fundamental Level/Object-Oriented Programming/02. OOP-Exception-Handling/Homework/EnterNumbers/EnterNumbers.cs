using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            int count = 10;
            int[] numbers = new int[count];

            Console.WriteLine("Plese enter 10 numbers: a1, a2, … a10, such that {0} < a1 < ... < a10 < {1}. ", start, end);
            for (int i = 0; i < count; i++)
            {
                Console.Write("Number a{0} : ", i + 1);
                int number = ReadNumber(start, end - count + i + 1);
                numbers[i] = number;
                start = number;
            }
        }

        static int ReadNumber(int start, int end)
        {
            bool isNotEnteredValidNUmber = true;
            int number = 0;
            do
            {
                string input = Console.ReadLine();
                try
                {
                    number = int.Parse(input);
                    if (number > start && number < end)
                    {
                        isNotEnteredValidNUmber = false;
                    }
                    else
                    {
                        Console.Write("The entered number is not in the range [{0}…{1}]. Please enter new number: ", start+1, end-1);
                    }
                }
                catch (FormatException ex)
                {
                    Console.Error.Write("The entered number is not in valid format. Please enter valid number: ");
                }
                
            } while (isNotEnteredValidNUmber);

            return number;
        }
    }
}
