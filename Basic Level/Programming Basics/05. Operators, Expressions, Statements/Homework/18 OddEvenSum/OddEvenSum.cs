using System;

    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= n*2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    sumOdd += number;
                }
                else
                {
                    sumEven += number;
                }
            }

            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes, sum=" + sumOdd);
            }
            else
            {
                Console.WriteLine("No, diff=" + Math.Abs(sumOdd-sumEven));
            }
        }
    }