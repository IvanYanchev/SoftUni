using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int myInt = int.Parse(Console.ReadLine());
                myInt += 1;
                Console.WriteLine(myInt);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double myDouble = double.Parse(Console.ReadLine());
                myDouble += 1;
                Console.WriteLine(myDouble);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string myString = Console.ReadLine();
                Console.WriteLine(myString + "*");
                break;
            default:
                Console.WriteLine("Not valid type!");
                break;
        }
    }
}