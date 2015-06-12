using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    class Parachute
    {
        static void Main(string[] args)
        {
            List<string> layout = new List<string>();
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                layout.Add(inputLine);
            }

            for (int row = 0; row < layout.Count; row++)
            {
                int jumperColPosition = layout[row].IndexOf('o');
                if (jumperColPosition >= 0)
                {
                    for (int jumperRowPosition = row + 1; jumperRowPosition < layout.Count; jumperRowPosition++)
                    {

                        for (int col = 0; col < layout[jumperRowPosition].Length; col++)
                        {
                            switch (layout[jumperRowPosition][col])
                            {
                                case '>':
                                    {
                                        jumperColPosition++;
                                        break;
                                    }
                                case '<':
                                    {
                                        jumperColPosition--;
                                        break;
                                    }
                            }
                        }
                        switch (layout[jumperRowPosition][jumperColPosition])
                        {
                            case '_':
                                {
                                    Console.WriteLine("Landed on the ground like a boss!");
                                    Console.WriteLine("{0} {1}", jumperRowPosition, jumperColPosition);
                                    return;
                                }
                            case '~':
                                {
                                    Console.WriteLine("Drowned in the water like a cat!");
                                    Console.WriteLine("{0} {1}", jumperRowPosition, jumperColPosition);
                                    return;
                                }
                            case '\\':
                            case '/':
                            case '|':
                                {
                                    Console.WriteLine("Got smacked on the rock like a dog!");
                                    Console.WriteLine("{0} {1}", jumperRowPosition, jumperColPosition);
                                    return;
                                }
                        }
                    }
                    break;
                }
            }
        }
    }
}
