using System;

    class SortingNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            foreach (var number in BubbleSortMethod(array))
            {
                Console.WriteLine(number);
            }
        }

        static int[] BubbleSortMethod(int[] array)
        {
            for (int i = array.Length; i >= 1; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }