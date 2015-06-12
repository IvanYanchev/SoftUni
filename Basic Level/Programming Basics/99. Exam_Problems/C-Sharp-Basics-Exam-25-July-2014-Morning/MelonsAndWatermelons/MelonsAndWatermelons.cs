using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelonsAndWatermelons
{
    class MelonsAndWatermelons
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());
            int countMelons = 0;
            int countWatermelons = 0;

            for (int i = 0; i < numberOfDays; i++)
            {
                if (dayOfWeek > 7)
                {
                    dayOfWeek = 1;
                }
                switch (dayOfWeek)
                {
                    case 1:
                        countWatermelons += 1;
                        break;
                    case 2:
                        countMelons += 2;
                        break;
                    case 3:
                        countMelons += 1;
                        countWatermelons += 1;
                        break;
                    case 4:
                        countWatermelons += 2;
                        break;
                    case 5:
                        countMelons += 2;
                        countWatermelons += 2;
                        break;
                    case 6:
                        countMelons += 2;
                        countWatermelons += 1;
                        break;
                    default:
                        break;
                }
                dayOfWeek++;
            }
            if (countMelons == countWatermelons)
            {
                Console.WriteLine("Equal amount: {0}", countMelons);
            }
            else if (countMelons > countWatermelons)
            {
                Console.WriteLine("{0} more melons", countMelons - countWatermelons);
            }
            else
            {
                Console.WriteLine("{0} more watermelons", countWatermelons - countMelons);
            }
        }
    }
}
