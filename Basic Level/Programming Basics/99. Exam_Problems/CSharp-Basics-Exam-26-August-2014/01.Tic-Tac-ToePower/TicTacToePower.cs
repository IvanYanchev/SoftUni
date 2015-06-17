using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tic_Tac_ToePower
{
    class TicTacToePower
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int index = y * 3 + x + 1;

            int startValue = int.Parse(Console.ReadLine());

            int indexValue = startValue + index - 1;

            long result = (long)Math.Pow(indexValue, index);

            Console.WriteLine(result);
        }
    }
}
