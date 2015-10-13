using System;

    class Boat
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2 + 1; i++) // upper part of the sail
            {
                string leftDots = new string('.', n - (2 * i - 1));
                string asteriskSail = new string('*', 2 * (i - 1) + 1);
                string rightDots = new string('.', n);
                string sailLine = leftDots + asteriskSail + rightDots;
                Console.WriteLine(sailLine);
            }
            for (int i = n / 2; i > 0; i--) // lower part of the sail
            {
                string leftDots = new string('.', n - (2 * i - 1));
                string asteriskSail = new string('*', 2 * (i - 1) + 1);
                string rightDots = new string('.', n);
                string sailLine = leftDots + asteriskSail + rightDots;
                Console.WriteLine(sailLine);
            }
            for (int i = 0; i < (n-1) / 2; i++) // boat body
            {
                string leftDots = new string('.', i);
                string asteriskBoat = new string('*', 2 * n - 2 * i);
                string rightDots = new string('.', i);
                string sailLine = leftDots + asteriskBoat + rightDots;
                Console.WriteLine(sailLine);
            }
        }
    }