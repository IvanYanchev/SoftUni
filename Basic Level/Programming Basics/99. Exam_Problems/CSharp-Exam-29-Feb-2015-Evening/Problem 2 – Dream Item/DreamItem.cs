using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Dream_Item
{
    public class DreamItem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputParameters = input.Split('\\'); // Month\Money per hour\Hours per day\Price of the item. 

            int daysInMonth = 0;

            switch (inputParameters[0])
            {
                case "Jan":
                case "Mar":
                case "May":
                case "July":
                case "Aug":
                case "Oct":
                case "Dec":
                    {
                        daysInMonth = 31;
                        break;
                    }
                case "Apr":
                case "June":
                case "Sept":
                case "Nov":
                    {
                        daysInMonth = 30;
                        break;
                    }
                case "Feb":
                    {
                        daysInMonth = 28;
                        break;
                    }
            }

            int workDaysPerMonth = daysInMonth - 10;

            int workHoursPerMonth = workDaysPerMonth * int.Parse(inputParameters[2]);

            double moneyPerMonth = workHoursPerMonth * double.Parse(inputParameters[1]);

            if (moneyPerMonth >= 700)
            {
                moneyPerMonth *= 1.10;
            }

            double diff = moneyPerMonth - double.Parse(inputParameters[3]);

            if (diff >= 0)
            {
                Console.WriteLine("Money left = {0:F2} leva.", diff);  
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", -diff);
            }
        }
    }
}
