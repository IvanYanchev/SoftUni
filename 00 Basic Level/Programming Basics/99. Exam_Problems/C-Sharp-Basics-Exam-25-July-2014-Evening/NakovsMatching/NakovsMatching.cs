using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakovsMatching
{
    class NakovsMatching
    {
        static int WeightSum(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum = sum + str[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 1; j < b.Length; j++)
                {
                    string aLeft = a.Substring(0, i);
                    string aRight = a.Substring(i);
                    string bLeft = b.Substring(0, j);
                    string bRight = b.Substring(j);
                    int nakovs = Math.Abs(WeightSum(aLeft) * WeightSum(bRight) - WeightSum(aRight) * WeightSum(bLeft));
                    if (nakovs <= d)
                    {
                        Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", aLeft, aRight, bLeft, bRight, nakovs);
                        isFound = true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
