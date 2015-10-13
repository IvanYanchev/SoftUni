using System;

    class ByteParty
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool partyIsOver = false;

            do
            {
                string commandLine = Console.ReadLine();
                if (commandLine != "party over")
                {
                    string[] commands = commandLine.Split(' ');
                    int position = int.Parse(commands[1]);

                    switch (commands[0])
                    {
                        case "-1":
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        int mask = 1 << position;
                                        int bit = (numbers[j] & mask) >> position;
                                        if (bit == 0)
                                        {
                                            numbers[j] = numbers[j] | mask;
                                        }
                                        else
                                        {
                                            mask = ~mask;
                                            numbers[j] = numbers[j] & mask;
                                        }
                                    }
                                }
                                break;
                        case "0":
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        int mask = ~(1 << position);
                                        numbers[j] = numbers[j] & mask;
                                    }
                                }
                                break;
                        case "1":
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        int mask = 1 << position;
                                        numbers[j] = numbers[j] | mask;
                                    }
                                }
                                break;
                    }
                }
                else
                {
                    partyIsOver = true;
                }
            } while (!partyIsOver);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }