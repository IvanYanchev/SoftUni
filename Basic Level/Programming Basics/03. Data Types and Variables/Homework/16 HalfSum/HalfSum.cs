using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int number;
        int sumLeft = 0;
        int sumRight = 0;
        int diff;

        for (int i = 1; i <= n; i++)
        {
            number = int.Parse(Console.ReadLine());
            sumLeft = sumLeft + number;
        }
        for (int i = (n + 1); i <= (n * 2); i++)
        {
            number = int.Parse(Console.ReadLine());
            sumRight = sumRight + number;
        }

        if (sumLeft == sumRight)
        {
            Console.WriteLine("Yes, sum=" + sumRight);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(sumLeft - sumRight));
        }
    }
}
