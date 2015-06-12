using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            for (int ch = 32; ch < 127; ch++)
            {
                int chCount = 0;
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString.ElementAt(i) == ch)
                    {
                        chCount += 1;
                    }
                }
                if (chCount > 0)
                {
                    Console.WriteLine("{0}: {1} time/s", (char)ch, chCount);
                }
            }
        }
    }
}
