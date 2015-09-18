using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculations
{
    class NumberCalculations
    {
        static void Main()
        {
            decimal[] numbers = { 8, 9, 3, 4, 5, 1, 5, 18, 2, -5 };
            Console.WriteLine("Min     = {0}", GetMin(numbers));
            Console.WriteLine("Max     = {0}", GetMax(numbers));
            Console.WriteLine("Average = {0}", GetAverage(numbers));
            Console.WriteLine("Sum     = {0}", GetSum(numbers));
            Console.WriteLine("Product = {0}", GetProduct(numbers));
        }

        static int GetMin(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static double GetMin(double[] arr)
        {
            double min = double.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static decimal GetMin(decimal[] arr)
        {
            decimal min = decimal.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static int GetMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static double GetMax(double[] arr)
        {
            double max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static decimal GetMax(decimal[] arr)
        {
            decimal max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static double GetAverage(int[] arr)
        {
            double sum = 0d;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = sum / (arr.Length - 1);
            return average;
        }

        static double GetAverage(double[] arr)
        {
            double sum = 0d;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = sum / (arr.Length - 1);
            return average;
        }

        static decimal GetAverage(decimal[] arr)
        {
            decimal sum = 0M;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            decimal average = sum / (arr.Length - 1);
            return average;
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static double GetSum(double[] arr)
        {
            double sum = 0d;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static decimal GetSum(decimal[] arr)
        {
            decimal sum = 0m;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static int GetProduct(int[] arr)
        {
            int product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        static double GetProduct(double[] arr)
        {
            double product = 1d;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

        static decimal GetProduct(decimal[] arr)
        {
            decimal product = 1m;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
    }
}
