using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookOrders
{
    class BookOrders
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            int totalBooksBought = 0;
            double priceForTotalBooksBought = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int packets = int.Parse(Console.ReadLine());
                int booksPerPacket = int.Parse(Console.ReadLine());
                double pricePerBook = double.Parse(Console.ReadLine());
                double discount = 0;
                if (packets >= 10 && packets < 110)
                {
                    discount = 0.05 + (double)(packets / 10 - 1) / 100;
                }
                else if (packets >= 110)
                {
                    discount = 0.15;
                }
                totalBooksBought += packets * booksPerPacket;
                priceForTotalBooksBought += packets * booksPerPacket * pricePerBook * (1 - discount);
            }

            Console.WriteLine(totalBooksBought);
            Console.WriteLine("{0:F2}", priceForTotalBooksBought);
        }
    }
}
