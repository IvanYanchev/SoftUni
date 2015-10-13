using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArraySort
{
    class GenericArraySort
    {
        static void Main()
        {
            int[] integerNumbers = { 1, 3, 4, 5, 1, 0, 5 };
            double[] realNumbers = { 0, 1.5, Math.PI, Math.E, Math.Sqrt(2) };
            string[] strings = { "zaz", "cba", "baa", "azis" };
            DateTime[] dates =
            {
                new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)
            };

            BubbleSortArray(integerNumbers);
            Console.WriteLine(string.Join(", ", integerNumbers));
            BubbleSortArray(realNumbers);
            Console.WriteLine(string.Join(", ", realNumbers));
            BubbleSortArray(strings);
            Console.WriteLine(string.Join(", ", strings));
            BubbleSortArray(dates);
            Console.WriteLine(string.Join(", ", dates));
        }

        static void BubbleSortArray<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length > 1)
            {
                for (int i = array.Length - 1; i >= 1; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
        }
    }
}
