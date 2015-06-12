using System;

    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double maxNumber = double.MinValue;

            if (a > maxNumber)
            {
                maxNumber = a;
            }
            if (b > maxNumber)
            {
                maxNumber = b;
            }
            if (c > maxNumber)
            {
                maxNumber = c;
            }
            Console.WriteLine(maxNumber);
        }
    }
