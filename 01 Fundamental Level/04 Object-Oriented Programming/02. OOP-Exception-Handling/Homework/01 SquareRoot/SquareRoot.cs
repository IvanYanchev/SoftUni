using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Invalid number");
                    return;
                }
                double result = Math.Sqrt(number);
                Console.WriteLine("Math.Sqrt({0}) = {1}", number, result);
            }
            catch (FormatException ex)
            {
                Console.Error.WriteLine("Invalid number");
            }
            catch (OverflowException ex)
            {
                Console.Error.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
