using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTheTorches
{
    class LightTheTorches
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] rooms = new char[n];

            string currentLightStatus = Console.ReadLine();

            int position = 0;

            for (int i = 0; i < n; i++)
            {
                if (position >= currentLightStatus.Length)
                {
                    position = 0;
                }

                rooms[i] = currentLightStatus[position];
                position++;
            }

            int currentPosition = n /2;
            int currentPositionNew = currentPosition;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] commandArguments = command.Split(' ');

                string direction = commandArguments[0];
                int moves = int.Parse(commandArguments[1]);

                switch (direction)
                {
                    case"LEFT":
                        {
                            if ((currentPosition - moves - 1) < 0 )
                            {
                                currentPositionNew = 0;
                            }
                            else
                            {
                                currentPositionNew -= moves + 1;
                            }
                            break;
                        }
                    case "RIGHT":
                        {
                            if ((currentPosition + moves + 1) >= rooms.Length)
                            {
                                currentPositionNew = rooms.Length - 1;
                            }
                            else
                            {
                                currentPositionNew += moves + 1;
                            }
                            break;
                        }
                }

                if (currentPositionNew != currentPosition)
                {
                    if (rooms[currentPositionNew] == 'D')
                    {
                        rooms[currentPositionNew] = 'L';
                    }
                    else
                    {
                        rooms[currentPositionNew] = 'D';
                    }
                    currentPosition = currentPositionNew;
                }
            }

            int countDarkRooms = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] == 'D')
                {
                    countDarkRooms++;
                }
            }

            Console.WriteLine( 'D' * countDarkRooms);
        }
    }
}
