using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter four-digit number in format abcd : ");
        int n = int.Parse(Console.ReadLine());
        int a = (n / 1000) % 10;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d = n % 10;

        int sumOfDigits = a + b + c + d;
        Console.WriteLine("Sum of digits: {0}", sumOfDigits);

        int reversed = 1000 * d + 100 * c + 10 * b + a;
        Console.WriteLine("Number in reversed order: {0}", reversed);

        int lastDigitFirst = 1000 * d + 100 * a + 10 * b + c;
        Console.WriteLine("The last digit in the first position: {0}", lastDigitFirst);

        int secondAndThirdDigitsExanged = 1000 * a + 100 * c + 10 * b + d;
        Console.WriteLine("Number with exchanged second and third digits: {0}", secondAndThirdDigitsExanged);
    }
}
