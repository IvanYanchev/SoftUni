using System;

    class BitsUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] element = new int [n]; // the n elements will be stored in a new array

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                element[i] = number; // input n elements from the console
            }

            for (int i = 0; i <= ((n * 8) - 2) / step; i++)
            {
                int bitPositionLeftToRifght = 2 + i * step;

                if (bitPositionLeftToRifght % 8 == 0)
                {
                    int index = (bitPositionLeftToRifght / 8) - 1;
                    int actualBitPositionInsideTheElemnt = (index + 1) * 8 - (2 + i * step);
                    int mask = 1 << actualBitPositionInsideTheElemnt;
                    element[index] |= mask;
                }
                else
                {
                    int index = (bitPositionLeftToRifght / 8);
                    int actualBitPositionInsideTheElemnt = (index + 1) * 8 - (2 + i * step);
                    int mask = 1 << actualBitPositionInsideTheElemnt;
                    element[index] |= mask;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(element[i]); 
            }
        }
    }