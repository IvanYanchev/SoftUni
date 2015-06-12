using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNumAndFindMinMaxAverage
{
    class CategorizeNumAndFindMinMaxAverage
    {
        static void FindAndPrintMinMaxAverage (List<float> list)
        {
            Console.Write("{0} {1} {2} -> ", '[', string.Join("; ", list), ']');
            Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:F2}", list.Min(), list.Max(), list.Sum(), list.Average());
        }

        static void Main(string[] args)
        {
            string inputLine = "1,2 -4 5,00 12211 93,003 4 2,2";
            float[] numbers = inputLine.Split(' ').Select(float.Parse).ToArray();
            List<float> roundNumbers = new List<float>();
            List<float> floatingPointNumbers = new List<float>();

            foreach (var number in numbers)
            {
                if (number == (int)number)
                {
                    roundNumbers.Add(number);
                }
                else
                {
                    floatingPointNumbers.Add(number);
                }
            }

            FindAndPrintMinMaxAverage(roundNumbers);
            FindAndPrintMinMaxAverage(floatingPointNumbers);
        }
    }
}
