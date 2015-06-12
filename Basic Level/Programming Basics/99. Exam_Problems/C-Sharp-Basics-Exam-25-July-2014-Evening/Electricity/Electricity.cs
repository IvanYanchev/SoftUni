using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());

        DateTime time = DateTime.Parse(Console.ReadLine());

        double sumWatts = 0;
        double powerLamps = 100.53;
        double powerComputers = 125.90;

        if (time >= DateTime.Parse("14:00") && time <= DateTime.Parse("18:59"))
        {
            sumWatts = floors * flats * (2 * powerLamps + 2 * powerComputers);
        }
        else if (time >= DateTime.Parse("19:00") && time <= DateTime.Parse("23:59"))
        {
            sumWatts = floors * flats * (7 * powerLamps + 6 * powerComputers);
        }
        else if (time >= DateTime.Parse("00:00") && time <= DateTime.Parse("08:59"))
        {
            sumWatts = floors * flats * (1 * powerLamps + 8 * powerComputers);
        }

        Console.WriteLine("{0} Watts", (int)sumWatts);
    }
}