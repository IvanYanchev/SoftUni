using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUpTheMess
{
    class CleanUpTheMess
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Mecanismo.cs"))
            {
                using (var writer = new StreamWriter("Fixed.cs"))
                {
                    do
	                {
	                    string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        line = line.TrimStart();
                        //if (line != "" && (line[line.Length - 1] != ';' || line[line.Length - 1] != '{' || line[line.Length - 1] != '}'))
                        //{
                        //    line = line.Replace(System.Environment.NewLine, "");
                        //}
                        writer.Write(line);

	                } while (true);
                }
            }
        }
    }
}
