using System;

    class TravellerBob
    {
        static void Main()
        {
            string leapYear = Console.ReadLine();
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());

            int normalMonths = 12 - contractMonths - familyMonths;
            int weeksPerMonth = 4;

            double travelsPerContractMonth = 3 * weeksPerMonth;
            double travelsPerFamilyMonth = 2 * (weeksPerMonth - 2);
            double travelsPerNormalMonth = 3.0 * travelsPerContractMonth / 5.0;
            double travelsPerYear = contractMonths * travelsPerContractMonth + familyMonths * travelsPerFamilyMonth + normalMonths * travelsPerNormalMonth;
            if (leapYear == "leap")
            {
                travelsPerYear = travelsPerYear * 1.05;
            }
            Console.WriteLine((int)travelsPerYear);
        }
    }