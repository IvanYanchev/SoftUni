using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoBlocks
{
    class LegoBlocks
    {
        static void ReadJArrayFromTheConsole(List<int>[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                List<int> newList = new List<int>();
                string input = Console.ReadLine().Trim();
                if (input != "")
                {
                    newList = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                }
                arr[i] = newList;
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] jaggedArray1 = new List<int>[n];
            List<int>[] jaggedArray2 = new List<int>[n];
            ReadJArrayFromTheConsole(jaggedArray1, n);
            ReadJArrayFromTheConsole(jaggedArray2, n);

            for (int i = 0; i < n; i++)
            {
                if (jaggedArray2[i].Count != 0)
                {
                    jaggedArray2[i].Reverse();
                    for (int j = 0; j < jaggedArray2[i].Count; j++)
                    {
                        jaggedArray1[i].Add(jaggedArray2[i][j]);
                    }
                }
            }

            bool allElementsAreWithEqualLenght = true;
            for (int i = 0; i < n-1; i++)
            {
                if (jaggedArray1[i].Count != jaggedArray1[i+1].Count)
                {
                    allElementsAreWithEqualLenght = false;
                }
            }
            if (allElementsAreWithEqualLenght)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("{0}{1}{2}", '[', string.Join(", ", jaggedArray1[i]), ']');
                }
            }
            else
            {
                int totalNumberOfCells = 0;
                for (int i = 0; i < n; i++)
			    {
			        totalNumberOfCells += jaggedArray1[i].Count;
			    }
                Console.WriteLine("The total number of cells is: {0}", totalNumberOfCells);
            }
        }
    }
}
