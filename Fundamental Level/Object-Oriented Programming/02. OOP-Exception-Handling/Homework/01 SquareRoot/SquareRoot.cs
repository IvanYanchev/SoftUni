using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double result = 0;
            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("The entered integer number shoud be > = 0");
                }
                else
                {
                    result = Math.Sqrt(number);
                    Console.WriteLine("Math.Sqrt({0}) = {1}", number, result);
                }
            }
            catch (FormatException ex)
            {
                Console.Error.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
