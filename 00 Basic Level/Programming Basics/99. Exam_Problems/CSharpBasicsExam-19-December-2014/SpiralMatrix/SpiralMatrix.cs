using System;

    class SpiralMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];
            string keyword = Console.ReadLine();

            char[] characters = keyword.ToCharArray();
            int indexRow = 0;
            int indexCol = 0;
            int indexChar = 0;
            int k = 0;

            while (true)
            {
                for (int i = 0; i < n - k; i++)
                {
                    if (indexChar >= characters.Length)
                    {
                        indexChar = 0;
                    }
                    matrix[indexRow, indexCol++] = characters[indexChar++];
                }
                indexCol--;
                k++;
                if (n-k > 0)
                {
                    for (int j = 0; j < n - k; j++)
                    {
                        if (indexChar >= characters.Length)
                        {
                            indexChar = 0;
                        }
                        matrix[++indexRow, indexCol] = characters[indexChar++];
                    }
                    for (int l = 0; l < n - k; l++)
                    {
                        if (indexChar >= characters.Length)
                        {
                            indexChar = 0;
                        }
                        matrix[indexRow, --indexCol] = characters[indexChar++];
                    }
                    k++;
                    if (n-k>0)
                    {
                        for (int m = 0; m < n - k; m++)
                        {
                            if (indexChar >= characters.Length)
                            {
                                indexChar = 0;
                            }
                            matrix[--indexRow, indexCol] = characters[indexChar++];
                        }
                        indexCol++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            int maxWeight = int.MinValue;
            int index = 0;

            for (int x = 0; x < n; x++)
            {
                int weight = 0;
                for (int y = 0; y < n; y++)
                {
                    int charCode = (int)matrix[x, y];
                    int charWeight;

                    if (charCode > 96)
                    {
                        charWeight = charCode - 96;
                    }
                    else
                    {
                        charWeight = charCode - 64;
                    }
                    
                    weight = weight + charWeight * 10;
                }
                if (weight > maxWeight)
                {
                    maxWeight = weight;
                    index = x;
                }
            }
            Console.WriteLine("{0} - {1}", index, maxWeight);
        }
    }