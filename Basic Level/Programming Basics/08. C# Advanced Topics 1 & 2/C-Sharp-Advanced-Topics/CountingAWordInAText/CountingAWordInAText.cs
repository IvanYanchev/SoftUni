using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingAWordInAText
{
    class CountingAWordInAText
    {
        static void Main(string[] args)
        {
            string inputWord = "SoftUni";
            string inputText = "The Software University (SoftUni) trains software engineers, gives them a profession and a job. Visit us at http://softuni.bg. Enjoy the SoftUnification at SoftUni.BG. Contact us.Email: INFO@SOFTUNI.BG. Facebook: https://www.facebook.com/SoftwareUniversity. YouTube: http://www.youtube.com/SoftwareUniversity. Google+: https://plus.google.com/+SoftuniBg/. Twitter: https://twitter.com/softunibg. GitHub: https://github.com/softuni";

            List<string> wordsInText = inputText.Split(new char[] { ' ', '.', ',', '!', '?', '“', '”', '(', ')', '@', '/', '\\', ':', '-', '+' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int count = 0;
            foreach (var word in wordsInText)
            {
                if (word.Equals(inputWord, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}