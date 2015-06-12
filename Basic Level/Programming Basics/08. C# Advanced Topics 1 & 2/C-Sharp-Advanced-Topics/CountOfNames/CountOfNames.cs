using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNames
{
    class CountOfNames
    {
        static void Main(string[] args)
        {
            string inputLine = "Peter Steve Nakov Steve Alex Nakov";
            List<string> inputNames = inputLine.Split(' ').ToList();
            inputNames.Sort();

            foreach (var name in inputNames.Distinct())
            {
                int occur = inputNames.Where(x => x.Equals(name)).Count();
                Console.WriteLine("{0} => {1}", name, occur);
            }
        }
    }
}
