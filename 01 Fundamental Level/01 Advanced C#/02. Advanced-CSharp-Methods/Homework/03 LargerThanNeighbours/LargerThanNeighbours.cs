using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 4, 5, 1, 0, 5 };
            for (int i = 0; i < arr.Length ; i++)
			{
                Console.WriteLine(IsLargerThanNeighbours(arr, i));
			}
        }

        static bool IsLargerThanNeighbours(int[] arr, int i)
        {
            bool result = false;

            if (i >= 1 && i <= arr.Length - 2)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    result = true;
                }
            }
            else if (i == 0)
            {
                if (arr[i] > arr[i + 1])
                {
                    result = true;
                }
            }
            else if (i == arr.Length - 1)
            {
                if (arr[i] > arr[i - 1])
                {
                    result = true;
                }
            }

            return result;
        }

    }
}
