using System;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); // Input n;
        int step = int.Parse(Console.ReadLine()); // Input step;
        int[] inputElement = new int[n];
        for (int i = 0; i < n; i++) // Input n numbers into new array
        {
            inputElement[i] = int.Parse(Console.ReadLine());
        }

        int totalBitsLenght = n * 8;  // Calculate the total lenght of the bits sequence
        int stepsCount = (totalBitsLenght - 2) / step; // calculate the number of steps inside the total bits sequence

        int z;
        if ((stepsCount + 1) % 8 == 0) // calculate how 
        {
            z = (stepsCount + 1) / 8; // many output bits 
        }
        else z = (stepsCount + 1) / 8 + 1; // (divided into bytes)

        int[] outputElement = new int[z]; // declare new array for the output bytes
        for (int y = 0; y < z; y++)
        {
            outputElement[y] = 0;  // initzialize all elements of the output array
        }

        for (int i = 0; i <= stepsCount; i++)
        {

            int position = 2 + i * step; //finding the bit on every position 1 + 0*step, 1 + 1*step, 1 + 2*step, ...
            int indexIn = position / 8;
            if (position % 8 == 0) indexIn = indexIn - 1;
            int bitsOffset = (8 + 8 * indexIn) - (2 + i * step);
            int mask = 1 << bitsOffset;
            int bit = inputElement[indexIn] & mask;
            bit = bit >> bitsOffset;

            int indexOut = (i + 1) / 8;
            if ((i + 1) % 8 == 0)
            {
                indexOut = indexOut - 1;
            }

            bit = bit << ((indexOut + 1) * 8 - (i + 1));
            outputElement[indexOut] = outputElement[indexOut] | bit;


        }

        for (int y = 0; y < z; y++)
        {
            Console.WriteLine(outputElement[y]);
        }
    }
}