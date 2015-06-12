using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (var reader = new StreamReader("../../Words.txt"))
            {
                using (var writer = new StreamWriter("../../Results.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        foreach (var word in line.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (!words.ContainsKey(word))
                            {
                                words.Add(word, 1);
                            }
                            else
                            {
                                words[word]++;
                            }
                        }
                        line = reader.ReadLine();
                    }

                    // write to Results.txt
                    foreach (var word in words.OrderBy(x => x.Key))
                    {
                        writer.WriteLine("{0} - {1}", word.Key, word.Value);
                    }
                }
            }
        }
    }
}
