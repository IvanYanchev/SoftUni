using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Please enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter number b: ");
        int b = int.Parse(Console.ReadLine());
        int minValue = Math.Min(Math.Abs(a), Math.Abs(b));
        int maxValue = Math.Max(Math.Abs(a), Math.Abs(b));
        int remainder = maxValue % minValue;

        do
        {
            if (remainder == 0)
            {
                break;
            }
            maxValue = minValue;
            minValue = remainder;
            remainder = maxValue % minValue;

        } while (true);

        Console.WriteLine("GCD(a, b) = {0}", minValue);
    }
}