using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitMarket
{
    class FruitMarket
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> price = new Dictionary<string, double>()
            {
                {"banana", 1.80},
                {"cucumber", 2.75},
                {"tomato", 3.20},
                {"orange", 1.60},
                {"apple", 0.86}
            };
            Dictionary<string, double> discount = new Dictionary<string, double>()
            {
                {"Monday", 0},
                {"Tuesday", 0.2},
                {"Wednesday", 0.1},
                {"Thursday", 0.3},
                {"Friday", 0.1},
                {"Saturday", 0},
                {"Sunday", 0.05}
            };

            double total = 0;

            string day = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                string product = Console.ReadLine();
                if ((day == "Friday" || day == "Sunday") ||
                    (day == "Tuesday" && (product == "banana" || product == "orange" || product == "apple")) ||
                    (day == "Wednesday" && (product == "cucumber" || product == "tomato" )) ||
                    (day == "Thursday" && product == "banana"))
                {
                    total = total + price[product] * quantity * (1 - discount[day]);
                }
                else
                {
                    total = total + price[product] * quantity;
                }
                
            }

            Console.WriteLine("{0:F2}", total);
        }
    }
}
