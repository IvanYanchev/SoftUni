using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandaScotlandFlag
{
    class PandaScotlandFlag
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch = 'A';

            for (int i = 0; i < n / 2; i++)
            {
                if (ch > 'Z')
                {
                    ch = 'A';
                }
                char ch1 = ch;
                ch++;
                if (ch > 'Z')
                {
                    ch = 'A';
                }
                char ch2 = ch;
                ch++;
                string wave = new string('~', i);
                string number = new string('#', n - 2 - 2 * i);
                Console.WriteLine("{0}{1}{2}{3}{0}", wave, ch1, number, ch2);
            }

            if (ch > 'Z')
            {
                ch = 'A';
            }
            string dash = new string('-', n / 2);
            Console.WriteLine("{0}{1}{0}", dash, ch++);

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                if (ch > 'Z')
                {
                    ch = 'A';
                }
                char ch1 = ch;
                ch++;
                if (ch > 'Z')
                {
                    ch = 'A';
                }
                char ch2 = ch;
                ch++;
                string wave = new string('~', i);
                string number = new string('#', n - 2 - 2 * i);
                Console.WriteLine("{0}{1}{2}{3}{0}", wave, ch1, number, ch2);
            }
        }
    }
}
