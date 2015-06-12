using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace ZippingSlicedFiles
{
    class ZippingSlicedFiles
    {
        static void SliceAndZip(string sourceFile, string destinationDirectory, int parts)
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
                    string destinationFile = string.Format("{0}//Part{1}.{2}.gz", destinationDirectory, i, fileName);
                    using (var destination = new FileStream(destinationFile, FileMode.Create))
                    {
                        using (var compress = new GZipStream(destination, CompressionMode.Compress))
                        {
                            byte[] buffer = new byte[bufferSize];
                            for (int j = 0; j <= partSize / bufferSize; j++)
                            {
                                int readBytes = source.Read(buffer, 0, buffer.Length);
                                compress.Write(buffer, 0, readBytes);
                            }
                        }
                    }
                }
            }
        }

        static void UnzipAndAssemble(List<string> files, string destinationDirectory)
        {
            FileInfo fileInfo = new FileInfo(files[0]);
            Regex fileName = new Regex(@"(.\w+)(?:.gz)");
            Match fileExt = fileName.Match(fileInfo.Name);
            string destinationFile = destinationDirectory + "//assemled" + fileExt.Groups[1].Value;

            using (var destination = new FileStream(destinationFile, FileMode.Append))
            {
                foreach (var file in files)
                {
                    using (var source = new FileStream(file, FileMode.Open))
                    {
                        using (var decompress = new GZipStream(source, CompressionMode.Decompress))
                        {
                            byte[] buffer = new byte[4096];
                            while (true)
                            {
                                int readBytes = decompress.Read(buffer, 0, buffer.Length);
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
        }

        static void Main(string[] args)
        {
            SliceAndZip("../../DSCF0572.jpg", "c:/Temp", 5);

            List<string> fileParts = new List<string>()
            {
                "../../Part1.DSCF0572.jpg.gz",
                "../../Part2.DSCF0572.jpg.gz",
                "../../Part3.DSCF0572.jpg.gz",
                "../../Part4.DSCF0572.jpg.gz",
                "../../Part5.DSCF0572.jpg.gz",
            };
            UnzipAndAssemble(fileParts, "c:/Temp");
        }
    }
}
