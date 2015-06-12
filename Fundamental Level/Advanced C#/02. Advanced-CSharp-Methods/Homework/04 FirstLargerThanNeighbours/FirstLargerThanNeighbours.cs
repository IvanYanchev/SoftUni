using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static int GetIndexOfFirstElementLargerThanNeighbours(int[] arr)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (((i == 0) && (arr[i] > arr[i + 1])) ||
                   ((i >= 1 && i <= arr.Length - 2) && (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])) ||
                   ((i == arr.Length - 1) && (arr[i] > arr[i - 1])))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            int[] sequenceOne = new int[] { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }
    }
}
