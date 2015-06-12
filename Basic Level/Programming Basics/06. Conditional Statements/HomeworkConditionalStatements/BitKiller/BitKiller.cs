using System;

    class BitKiller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            long consolidatedBits = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                long mask = numbers[i] << (n - 1 - i) * 8;
                consolidatedBits |= mask;
            }

            int stepsCount = (n * 8 - 2) / step;

            for (int j = stepsCount; j >= 0; j--)
			{
                int position = 2 + j * step; // counting from left to right

                for (int k = n * 8 - position - 1; k >=0 ; k--)  //starting from the most right position
                {
                    long bitMask = 1 << k;
                    long bitExtracted = consolidatedBits & bitMask;
                    bitExtracted = bitExtracted >> k;
                    bitMask = bitExtracted << k + 1;
                    if (bitExtracted == 0)
                    {
                        consolidatedBits = consolidatedBits & bitExtracted;
                    }
                    else
                    {
                        consolidatedBits = consolidatedBits | bitExtracted;
                    }
                        
                }
                consolidatedBits = consolidatedBits & (~(1));
			}

            int outputBytes = (stepsCount + 1) / 8 + 1;
            if ((stepsCount + 1) % 8 == 0) outputBytes = outputBytes - 1;

            for (int l = 0; l < outputBytes; l++)
            {
                long temp = consolidatedBits;
                temp = temp << l * 8;
                temp = temp >> (outputBytes - 1) * 8;
                Console.WriteLine(temp);
            }
        }
    }
