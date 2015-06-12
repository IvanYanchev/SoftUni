using System;

    class Integers
    {
        static void Main()
        {
            int[] array = new int[10];
            Random element = new Random();

            array[0] = element.Next(0, 101);

            for (int i = 1; i < 10; i++)
            {
                int newRandomElement = element.Next(0, 101);
                array[i] = array[i-1] + newRandomElement;
                Console.WriteLine("{0} + {1} = {2}", array[i-1], newRandomElement, array[i]);
            }
        }
    }