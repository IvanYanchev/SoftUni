using System;

class DivideBy7And5
{
    static void Main()
    {
            Console.Write("Please enter integer number to check if it can be divided (without remainder) by 7 and 5 : ");
            int num = int.Parse(Console.ReadLine());
            bool canBeDividedBy7 = (num % 7) == 0;
            bool canBeDividedBy5 = (num % 5) == 0;
            Console.WriteLine("Result: {0}", num != 0 && canBeDividedBy7 && canBeDividedBy5);
    }
}
