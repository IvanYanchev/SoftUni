using System;

    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double temp;

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            } 
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }