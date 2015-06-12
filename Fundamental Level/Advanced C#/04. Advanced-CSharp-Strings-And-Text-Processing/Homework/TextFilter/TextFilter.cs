﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string bannedWordsListString = Console.ReadLine();

            string inputText = Console.ReadLine();

            string outputText = inputText;

            foreach (var word in bannedWordsListString.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries))
            {
                outputText = outputText.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(outputText);
        }
    }
}
