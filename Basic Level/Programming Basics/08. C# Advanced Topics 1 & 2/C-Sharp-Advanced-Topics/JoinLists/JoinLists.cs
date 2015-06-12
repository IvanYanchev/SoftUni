using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            string firstList = "20 40 10 10 30 80";
            string secondList = "25 20 40 30 10";
            List<string> numbersFromFirstList = firstList.Split(' ').ToList();
            List<string> numbersFromSecondList = secondList.Split(' ').ToList();

            foreach (var number in numbersFromSecondList)
            {
                numbersFromFirstList.Add(number);
            }
            numbersFromFirstList.Sort();
            foreach (var number in numbersFromFirstList.Distinct<string>())
            {
                Console.Write("{0} ", number);
            }
        }
    }
}
