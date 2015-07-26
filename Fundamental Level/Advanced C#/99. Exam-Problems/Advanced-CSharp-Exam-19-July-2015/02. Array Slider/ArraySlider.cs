using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Slider
{
    class ArraySlider
    {
        static void Main(string[] args)
        {
            string inputNumbers = Console.ReadLine();

            BigInteger[] elements = inputNumbers.Split(null as char[], StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();

            int currentPosition = 0;

            while (true)
            {
                string commandLine = Console.ReadLine();

                if (commandLine == "stop")
                {
                    break;
                }

                string[] commandArguments = commandLine.Split(' ');

                int offset = int.Parse(commandArguments[0]);

                currentPosition += offset;
                currentPosition %= elements.Length;

                if (currentPosition < 0)
                {
                    currentPosition = elements.Length + currentPosition;
                }

                string operation = commandArguments[1];
                int operand = int.Parse(commandArguments[2]);

                switch (operation)
                {
                    case "&":
                        {
                            elements[currentPosition] &= operand;
                            break;
                        }
                    case "|":
                        {
                            elements[currentPosition] |= operand;
                            break;
                        }
                    case "^":
                        {
                            elements[currentPosition] ^= operand;
                            break;
                        }
                    case "+":
                        {
                            elements[currentPosition] += operand;
                            break;
                        }
                    case "-":
                        {
                            elements[currentPosition] -= operand;
                            if (elements[currentPosition] < 0)
                            {
                                elements[currentPosition] = 0;
                            }
                            break;
                        }
                    case "*":
                        {
                            elements[currentPosition] *= operand;
                            break;
                        }
                    case "/":
                        {
                            elements[currentPosition] /= operand;
                            break;
                        }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", elements));
        }
    }
}
