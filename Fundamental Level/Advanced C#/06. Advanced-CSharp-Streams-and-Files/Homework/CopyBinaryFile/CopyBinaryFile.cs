using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            FileStream source = new FileStream("../../mini.jpg", FileMode.Open);
            FileStream copy = new FileStream("../../copy_of_mini.jpg", FileMode.Create);

            using (source)
            {
                using (copy)
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        copy.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
