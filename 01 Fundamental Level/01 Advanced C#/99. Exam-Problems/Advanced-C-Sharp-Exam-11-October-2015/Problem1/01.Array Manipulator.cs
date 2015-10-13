using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Problem1
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> result = new List<int>();
            List<int> subResult = new List<int>();

            string evenOrOdd = string.Empty;

            while (true)
            {
                result.Clear();
                subResult.Clear();

                string commandLine = Console.ReadLine();
                if (commandLine == "end")
                {
                    Print(array);
                    break;
                }

                string[] commands = commandLine.Split(' ');

                switch (commands[0])
                {
                    case "exchange":
                        int index = int.Parse(commands[1]);
                        if (index < 0 || index >= array.Length)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            for (int i = index + 1; i < array.Length; i++)
                            {
                                result.Add(array[i]);
                            }
                            for (int i = 0; i <= index; i++)
                            {
                                result.Add(array[i]);
                            }
                            array = result.ToArray();
                        }
                        break;
                    case "max":
                        evenOrOdd = commands[1];
                        if (FindIndexMax(evenOrOdd, array) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(FindIndexMax(evenOrOdd, array));
                        }
                        break;
                    case "min":
                        evenOrOdd = commands[1];
                        if (FindIndexMin(evenOrOdd, array) == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(FindIndexMin(evenOrOdd, array));
                        }
                        break;
                    case "first":
                        int countFirst = int.Parse(commands[1]);
                        evenOrOdd = commands[2];
                        result = FindOddEvenElements(evenOrOdd, array);
                        if (countFirst > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (result.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                for (int i = 0; i < Math.Min(countFirst, result.Count); i++)
                                {
                                    subResult.Add(result[i]);
                                }
                                Print(subResult);
                            }
                        }
                        break;
                    case "last":
                        int countLast = int.Parse(commands[1]);
                        evenOrOdd = commands[2];
                        result = FindOddEvenElements(evenOrOdd, array);
                        if (countLast > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (result.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                result.Reverse();
                                for (int i = 0; i < Math.Min(countLast, result.Count); i++)
                                {
                                    subResult.Add(result[i]);
                                }
                                subResult.Reverse();
                                Print(subResult);
                            }
                        }
                        break;
                }
            }
        }


        static int FindIndexMin(string str, int[] array)
        {
            int minElement = int.MaxValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if ((str == "odd" && array[i] % 2 != 0) || (str == "even" && array[i] % 2 == 0))
                {
                    if (array[i] <= minElement)
                    {
                        minElement = array[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        static int FindIndexMax(string str, int[] array)
        {
            int maxElement = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if ((str == "odd" && array[i] % 2 != 0) || (str == "even" && array[i] % 2 == 0))
                {
                    if (array[i] >= maxElement)
                    {
                        maxElement = array[i];
                        index = i;
                    }
                }
            }

            return index;
        }

        static void Print(List<int> list)
        {
            Console.WriteLine("[{0}]", string.Join(", ", list));
        }

        static void Print(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        static List<int> FindOddEvenElements(string str, int[] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (str == "even" && array[i] % 2 == 0)
                {
                    list.Add(array[i]);
                }
                else if(str == "odd" && array[i] % 2 != 0)
                {
                    list.Add(array[i]);
                }
            }

            return list;
        }
    }
}
