using System;

    class LongestNonDecreasingSubsequence
    {
        static void longest(int[] A)
        {
            int[] lenght = new int[A.Length];
            int lenghtMax = 0;
            int index = 0;

            for (int i = 0; i < A.Length; i++)
            {
                lenght[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (A[i] >= A[j])
                    {
                        lenght[i] = Math.Max(lenght[i], lenght[j] + 1);
                        lenghtMax = Math.Max(lenghtMax, lenght[i]);
                        index = i;
                    }
                }
            }
            Console.WriteLine(lenghtMax);
        }

        static void Main()
        {
            string inputLine = "11 12 13 3 14 4 15 5 6 7 8 7 16 9 8";
            string[] inputNumbersAsStrings = inputLine.Split(' ');
            int[] inputNumbers = new int[inputNumbersAsStrings.Length];
            for (int i = 0; i < inputNumbersAsStrings.Length; i++)
            {
                inputNumbers[i] = int.Parse(inputNumbersAsStrings[i]);
            }

            int[] subsequenceLenghtsArray = new int[inputNumbers.Length];

            longest(inputNumbers);
        }
    }