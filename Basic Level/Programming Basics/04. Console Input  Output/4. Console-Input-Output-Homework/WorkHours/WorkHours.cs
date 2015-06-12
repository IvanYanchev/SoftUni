using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        double actualWorkingDays = 0.9 * d;
        double actualWorkingHours = actualWorkingDays * 12;
        double efficientWorkingHours = (p / 100.0) * actualWorkingHours;

        int difference = (int)efficientWorkingHours - h;

        if (difference >= 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }

        Console.WriteLine(difference);
    }
}