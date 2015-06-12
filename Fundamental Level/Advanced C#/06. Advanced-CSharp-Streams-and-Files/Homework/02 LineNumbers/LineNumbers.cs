using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../Text.txt");
            StreamWriter writer = new StreamWriter("../../LineNumbersText.txt");

            using(reader)
            {
                using (writer)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        line = string.Format("{0,3} {1}", lineNumber, line);
                        writer.WriteLine(line);
                        lineNumber++;
                        line = reader.ReadLine();
                    }

                }
            }

        }
    }
}
