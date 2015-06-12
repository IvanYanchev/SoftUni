using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlicingFile
{
    class SlicingFile
    {
        static void Slice(string sourceFile, string destinationDirectory, int parts) 
        {
            int bufferSize = 4096;
            FileInfo fileInfo = new FileInfo(sourceFile);
            long fileSize = fileInfo.Length;
            long partSize = fileSize / parts;
            string fileName = fileInfo.Name;
            string fileExt = fileInfo.Extension;

            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                for (int i = 1; i <= parts; i++)
                {
                    string destinationFile = string.Format("{0}//Part{1}{2}", destinationDirectory, i, fileExt);
                    using (var destination = new FileStream(destinationFile, FileMode.Create))
                    {
                        byte[] buffer = new byte[bufferSize];
                        for (int j = 0; j <= partSize / bufferSize; j++)
			            {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            //if (readBytes == 0)
                            //{
                            //    break;
                            //}
                            destination.Write(buffer, 0, readBytes);
			            }
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            FileInfo fileInfo = new FileInfo(files[0]);
            string fileExt = fileInfo.Extension;
            string destinationFile = destinationDirectory + "//assemled" + fileExt;

            using (var destination = new FileStream(destinationFile, FileMode.Append))
            {
                foreach (var file in files)
                {
                    using (var source = new FileStream(file, FileMode.Open))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = source.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }
                            destination.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Slice("../../DSCF0572.jpg", "c:/Temp", 5);

            List<string> fileParts = new List<string>()
            {
                "../../Part1.jpg",
                "../../Part2.jpg",
                "../../Part3.jpg",
                "../../Part4.jpg",
                "../../Part5.jpg",
            };
            Assemble(fileParts, "c:/Temp");
        }
    }
}
