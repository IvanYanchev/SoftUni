using System;

class MoonGravitation
{
    static void Main()
    {
        Console.Write("Please enter your weight on the Earth: ");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = 0.17 * weightOnEarth;
        Console.WriteLine("Your wight on the Moon will be: {0} kg.", weightOnMoon);
    }
}
