using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int count = 0;

        for (int num = start; num <= end; num++)
        {
            if (num % 5 == 0)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}