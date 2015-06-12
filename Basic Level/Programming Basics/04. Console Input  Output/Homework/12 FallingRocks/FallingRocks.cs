using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

struct Dwarf
{
    public int x;
    public int y;
    public string s;
    public ConsoleColor color;
}

struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

class FallingRocks
{
    static void PrintDwarfOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }
    static void PrintRockOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }
    static void Main()
    {
        double speed = 100.0;
        int playfieldWidth = 15;
        int livesCount = 5;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 50;

        Dwarf dwarf = new Dwarf();
        {
            dwarf.x = 2;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.s = "(0)";
            dwarf.color = ConsoleColor.Yellow;
        }
        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();

        while (true)
        {
            speed = speed + 5;
            //How can I print the messages bellow? They're not showing if I put them in these if-loops
            //while (speed < 200)
            //{
            //    PrintStringOnPosition(playfieldWidth + 3, 6, "Level 1", ConsoleColor.White);
            //}
            //if (speed >= 200 && speed < 300)
            //{
            //    PrintStringOnPosition(playfieldWidth + 3, 6, "Level 2", ConsoleColor.White);
            //}
            //if (speed >= 300 && speed < 400)
            //{
            //    PrintStringOnPosition(playfieldWidth + 3, 6, "Level 3", ConsoleColor.White);
            //}
            if (speed > 400)
            {
                //PrintStringOnPosition(playfieldWidth + 3, 6, "Max Level reached", ConsoleColor.White);
                speed = 400;
            }
            bool isHit = false;
            //bool getsBonus = false;
            {
                // adding bonus objects
                int chance = randomGenerator.Next(0, 100);
                if (chance < 10)
                {
                    Object bonus = new Object();
                    bonus.color = ConsoleColor.Blue;
                    bonus.c = '@';
                    bonus.x = randomGenerator.Next(0, playfieldWidth);
                    bonus.y = 0;
                    objects.Add(bonus);
                }
                else if (chance < 20)
                {
                    Object bonus = new Object();
                    bonus.color = ConsoleColor.DarkMagenta;
                    bonus.c = '%';
                    bonus.x = randomGenerator.Next(0, playfieldWidth);
                    bonus.y = 0;
                    objects.Add(bonus);
                }
                else
                {
                    Object newRock = new Object();
                    newRock.color = ConsoleColor.Green;
                    newRock.x = randomGenerator.Next(0, playfieldWidth);
                    newRock.y = 0;
                    newRock.c = '#';
                    objects.Add(newRock);
                }
            }

            // move the dwarf (key pressed)
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playfieldWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }

            //creating new list of rocks
            List<Object> newListOfRocks = new List<Object>();

            // move rocks
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldRock = objects[i];
                Object newObject = new Object();
                newObject.x = oldRock.x;
                newObject.y = oldRock.y + 1;
                newObject.c = oldRock.c;
                newObject.color = oldRock.color;

                // check if rocks are hitting the dwarf
                if (newObject.c == '%' && newObject.y == dwarf.y && newObject.x == dwarf.x)
                {
                    speed -= 50;
                }
                if (newObject.c == '@' && newObject.y == dwarf.y && newObject.x == dwarf.x)
                {
                    livesCount++;
                }
                if (newObject.c == '#' && newObject.y == dwarf.y && newObject.x == dwarf.x)
                {
                    livesCount--;
                    isHit = true;
                    speed = 100;
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(playfieldWidth + 3, 10, "!!!GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(playfieldWidth + 3, 12, "Press [ENTER] to exit...", ConsoleColor.Gray);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newListOfRocks.Add(newObject);
                }
            }
            objects = newListOfRocks;

            // clear the console
            Console.Clear();

            // redraw playfield            
            if (isHit)
            {
                Console.Beep();
                objects.Clear();
                PrintRockOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintDwarfOnPosition(dwarf.x, dwarf.y, dwarf.s, dwarf.color);
            }

            //if (getsBonus)
            //{                
            //    PrintRockOnPosition(dwarf.x, dwarf.y, 'B', ConsoleColor.White);
            //    PrintRockOnPosition(dwarf.x, dwarf.y, 'B', ConsoleColor.White);
            //}
            //else
            //{
            //    PrintDwarfOnPosition(dwarf.x, dwarf.y, dwarf.s, dwarf.color);
            //}

            foreach (Object rock in objects)
            {
                PrintRockOnPosition(rock.x, rock.y, rock.c, rock.color);
            }

            // draw info
            PrintStringOnPosition(playfieldWidth + 3, 4, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(playfieldWidth + 3, 5, "Speed: " + speed, ConsoleColor.White);

            // slow down program
            Thread.Sleep((int)(600 - speed));
        }
    }
}