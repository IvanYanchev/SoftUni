using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../File.txt", System.Text.Encoding.UTF8);
            using (sr)
            {
                int lineNumber = 0;
                string lineText = sr.ReadLine();
                while (lineText != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(lineText);
                    }
                    lineNumber++;
                    lineText = sr.ReadLine();
                }
            }
        }
    }
}
