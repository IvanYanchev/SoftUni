using System;

    class Volleyball
    {
        static void Main()
        {
            string isLeap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); // number of holidays
            int h = int.Parse(Console.ReadLine()); //number of weeks he goes to his hometown

            double normalWeekends = 48 - h;
            double weekendsNotAtWork = normalWeekends * 3 / 4.0;
            double holidaysVoley = p * 2 / 3.0;
            double counter = weekendsNotAtWork + h + holidaysVoley;

            if (isLeap == "leap")
            {
                counter = counter * 1.15;
            }

            Console.WriteLine((int)counter);
        }
    }
