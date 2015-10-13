using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        int result = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            int bit = int.Parse(inputString.Substring(i, 1));
            result += (int)Math.Pow(2, inputString.Length - i - 1) * bit;
        }

        Console.WriteLine(result);
    }
}