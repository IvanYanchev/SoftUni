using System;

    class Beers
    {
        static void Main()
        {
            int stacks = 0;
            int beers = 0;
            bool thisIsTheEnd = false;

            do
            {
                string inputString = Console.ReadLine();
                if (inputString == "End")
                {
                    thisIsTheEnd = true;
                }
                else
                {
                    string[] measure = inputString.Split(' ');
                    if (measure[1] == "stacks")
                    {
                        stacks += int.Parse(measure[0]);
                    }
                    else if (measure[1] == "beers")
                    {
                        beers += int.Parse(measure[0]);
                    }
                }
                
            } while (!thisIsTheEnd);

            stacks = stacks + beers / 20;
            beers = beers % 20;

            Console.WriteLine("{0} stacks + {1} beers", stacks, beers);
        }
    }