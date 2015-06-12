using System;

    class CalculateGCD
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
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

            Console.WriteLine(minValue);
        }
    }