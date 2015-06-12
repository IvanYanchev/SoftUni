using System;

    class ExchangeIfGreater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c;
            bool aIsBiggerThanB = a > b;

            if (aIsBiggerThanB)
            {
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine("{0} {1}", a, b);
        }
    }