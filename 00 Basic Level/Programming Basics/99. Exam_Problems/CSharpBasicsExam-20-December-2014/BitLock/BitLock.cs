using System;

    class BitLock
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            string[] inputNumbersAsText = inputLine.Split(' ');
            int[] inputNumbers = new int[inputNumbersAsText.Length];
            for (int i = 0; i < inputNumbersAsText.Length; i++)
            {
                inputNumbers[i] = int.Parse(inputNumbersAsText[i]);
            }


            bool notTheEnd = true;

            do
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand == "end")
                {
                    notTheEnd = false;
                }
                else
                {
                    string[] commands = inputCommand.Split(' ');
                    switch (commands[0])
                    {
                        case "check":
                            {
                                int sum = 0;
                                for (int i = 0; i < inputNumbersAsText.Length; i++)
                                {
                                    int col = int.Parse(commands[1]);
                                    int bit = (inputNumbers[i] & (1 << col)) >> col;
                                    sum = sum + bit;
                                }
                                Console.WriteLine(sum);
                            }
                            break;
                        default:
                            {
                                int row = int.Parse(commands[0]);
                                string direction = commands[1];
                                int rotations = int.Parse(commands[2]);
                                switch (direction)
                                {
                                    case "left":
                                        {
                                            for (int j = 0; j < rotations; j++)
                                            {
                                                inputNumbers[row] = inputNumbers[row] << 1;
                                                int bitToRoll = (inputNumbers[row] & (1 << 12)) >> 12;
                                                inputNumbers[row] = inputNumbers[row] & ~(1 << 12);
                                                inputNumbers[row] = inputNumbers[row] | bitToRoll;
                                            }
                                        }
                                        break;
                                    case "right":
                                        {
                                            for (int j = 0; j < rotations; j++)
                                            {
                                                int bitToRoll = inputNumbers[row] & 1;
                                                inputNumbers[row] = inputNumbers[row] >> 1;
                                                bitToRoll = bitToRoll << 11;
                                                inputNumbers[row] = inputNumbers[row] | bitToRoll;
                                            }
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
            } while (notTheEnd);

            
            for (int i = 0; i < inputNumbersAsText.Length; i++)
            {
                Console.Write("{0} ", inputNumbers[i]);
            }
        }
    }