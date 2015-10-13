using System;

    class PiggyBank
    {
        static void Main()
        {
            int tankPrice = int.Parse(Console.ReadLine());
            int numberOfPartyDays = int.Parse(Console.ReadLine());
            int savings = 0;
            int months;
            int years;

            savings = (30 - numberOfPartyDays) * 2 - numberOfPartyDays * 5; // per month

            if (savings > 0)
            {
                months = tankPrice / savings;
                if (tankPrice % savings != 0)
                {
                    months = months + 1;
                }
                years = months / 12;
                months = months - years * 12;
                Console.WriteLine("{0} years, {1} months", years, months);
            }
            else
            {
                Console.WriteLine("never");
            }
        }
    }