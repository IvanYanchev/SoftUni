using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfLetters
{
    class CountOfLetters
    {
        static void Main(string[] args)
        {
            string inputLine = "h d h a a a s d f d a d j d s h a a";
            List<string> inputChars = inputLine.Split(' ').ToList();
            inputChars.Sort();

            foreach (var character in inputChars.Distinct())
            {
                int occur = inputChars.Where(x => x.Equals(character)).Count();
                Console.WriteLine("{0} => {1}", character, occur);
            }
        }
    }
}
