using System;

    class PrintingNumbers
    {
        static void Main(string[] args)
        {
            int minRange = int.Parse(Console.ReadLine());
            int maxRange = int.Parse(Console.ReadLine());
            PrintEvenNumbers(minRange, maxRange);
        }


        static void PrintEvenNumbers(int min, int max)
        {
            for (int i = min; i <= max; i++)
			{
                if (i % 2 == 0) Console.WriteLine(i);
			}
        }
    }