using System;

    class LastDigit
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            lastDigit(number);
           
        }
        private static void lastDigit(int n)
        {
            int m = n % 10;
            Console.WriteLine(m);
        }
    }

