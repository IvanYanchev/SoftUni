using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtGivenPosition
{
    class CheckBitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position p of bit to check: ");
            int positionOfBitToExtract = int.Parse(Console.ReadLine());
            int mask = 1;
            bool result = ((n >> positionOfBitToExtract) & mask) == 1;
            Console.WriteLine("bit @ p == 1: {0}", result);
        }
    }
}
