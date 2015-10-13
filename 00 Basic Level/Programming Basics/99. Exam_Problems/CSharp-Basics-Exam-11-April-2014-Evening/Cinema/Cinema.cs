using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = 0;

            switch (typeOfProjection)
            {
                case "Premiere": income = row * col * 12; break;
                case "Normal": income = row * col * 7.50; break;
                case "Discount": income = row * col * 5; break;
            }

            Console.WriteLine("{0:0.00} leva", income);
        }
    }
}
