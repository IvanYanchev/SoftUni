using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please enter integer number to check if its third digit from right-to-left is 7 : ");
        int num = int.Parse(Console.ReadLine());
        int numWithoutTheLast2Digits = num / 100;
        bool result = numWithoutTheLast2Digits % 10 == 7;
        Console.WriteLine("Result: {0}", result);
    }
}