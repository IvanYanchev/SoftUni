using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Dumbbell
{
    public class Dumbbell
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string left = new string('.', n / 2) + new string('&', n / 2 + 1);
            string middle = new string('.', n);
            string right = new string('&', n / 2 + 1) + new string('.', n / 2);

            string top = left + middle + right;
            Console.WriteLine(top);

            for (int i = n /2 - 1; i >= 0; i--)
            {
                left = new string('.', i) + '&' + new string('*', n - 2 - i) + '&';
                right = '&' + new string('*', n - 2 - i) + '&' + new string('.', i);
                if (i == 0)
                {
                    middle = new string('=', n);
                }
                string intermidiate = left + middle + right;
                Console.WriteLine(intermidiate);
            }

            for (int i = 1; i < n / 2; i++)
            {
                left = new string('.', i) + '&' + new string('*', n - 2 - i) + '&';
                middle = new string('.', n);
                right = '&' + new string('*', n - 2 - i) + '&' + new string('.', i);
                string intermidiate = left + middle + right;
                Console.WriteLine(intermidiate);
            }

            left = new string('.', n / 2) + new string('&', n / 2 + 1);
            middle = new string('.', n);
            right = new string('&', n / 2 + 1) + new string('.', n / 2);

            string bottom = left + middle + right;
            Console.WriteLine(bottom);
        }
    }
}
