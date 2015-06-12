using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length != 1)
            {
                while (true)
                {
                    string commandLine = Console.ReadLine();
                    if (commandLine == "end")
                    {
                        break;
                    }

                    string[] commands = commandLine.Split(' ');
                    if ((commands.Length == 5 && int.Parse(commands[2]) + int.Parse(commands[4]) > arr.Length) ||
                        (commands.Length == 5 && int.Parse(commands[2]) < 0) ||
                        (commands.Length == 5 && int.Parse(commands[4]) < 0))
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        switch (commands[0])
                        {
                            case "reverse":
                                {
                                    int start = int.Parse(commands[2]);
                                    int count = int.Parse(commands[4]);
                                    if (count == 0)
                                    {
                                        Console.WriteLine("Invalid input parameters.");
                                        break;
                                    }
                                    string[] subArr = arr.Skip(start).Take(count).Reverse().ToArray();
                                    for (int i = 0; i < count; i++)
                                    {
                                        arr[start + i] = subArr[i];
                                    }
                                    break;
                                }
                            case "sort":
                                {
                                    int start = int.Parse(commands[2]);
                                    int count = int.Parse(commands[4]);
                                    if (count == 0)
                                    {
                                        Console.WriteLine("Invalid input parameters.");
                                        break;
                                    }
                                    string[] subArr = arr.Skip(start).Take(count).OrderBy(x => x).ToArray();
                                    for (int i = 0; i < count; i++)
                                    {
                                        arr[start + i] = subArr[i];
                                    }
                                    break;
                                }
                            case "rollLeft":
                                {
                                    int count = int.Parse(commands[1]) % arr.Length;
                                    for (int i = 0; i < count; i++)
                                    {
                                        string temp = arr[0];
                                        for (int j = 0; j < arr.Length - 1; j++)
                                        {
                                            arr[j] = arr[j + 1];
                                        }
                                        arr[arr.Length - 1] = temp;
                                    }
                                    break;
                                }
                            case "rollRight":
                                {
                                    int count = int.Parse(commands[1]) % arr.Length;
                                    for (int i = 0; i < count; i++)
                                    {
                                        string temp = arr[arr.Length - 1];
                                        for (int j = arr.Length - 1; j >= 1; j--)
                                        {
                                            arr[j] = arr[j - 1];
                                        }
                                        arr[0] = temp;
                                    }
                                    break;
                                }
                        }
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
    }
}
