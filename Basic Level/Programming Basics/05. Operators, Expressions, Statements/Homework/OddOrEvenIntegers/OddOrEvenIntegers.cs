using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int[] numbers = new int[5];
        numbers[0] = 3;
        numbers[1] = 2;
        numbers[2] = -2;
        numbers[3] = -1;
        numbers[4] = 0;

        for (int i = 0; i < 5; i++)
        {
            bool isOdd = (numbers[i] % 2) != 0;
            Console.WriteLine(isOdd);
        }
    }
}
