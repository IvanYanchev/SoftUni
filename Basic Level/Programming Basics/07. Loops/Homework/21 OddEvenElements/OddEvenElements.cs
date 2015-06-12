using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == null)
            {
                Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={0}, EvenMin={0}, EvenMax={0}", "No");
                return;
            }
            string[] inputNumbers = inputLine.Split(' ');
            int elementsCount = inputNumbers.Length;
            if (elementsCount == 1)
            {
                Console.WriteLine("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum={1}, EvenMin={1}, EvenMax={1}", double.Parse(inputNumbers[0]), "No");
                return;
            }
            double sumOdd = 0.0;
            double sumEven = 0.0;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;

            for (int i = 0; i < elementsCount; i += 2)
            {
                double element = double.Parse(inputNumbers[i]);
                sumOdd += element;
                if (element > maxOdd) maxOdd = element;
                if (element < minOdd) minOdd = element;
                if ((i + 1) >= elementsCount) break;
                else
                {
                    element = double.Parse(inputNumbers[i+1]);
                    sumEven += element;
                    if (element > maxEven) maxEven = element;
                    if (element < minEven) minEven = element;
                }
            }
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", sumOdd,minOdd,maxOdd,sumEven,minEven,maxEven);
        }
    }
}
