using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptTheMessages
{
    class EncryptTheMessages
    {
        static void Main(string[] args)
        {
            List<char[]> encryptedMassages = new List<char[]>();

            string inputString = null;
            do
            {
                inputString = Console.ReadLine();
                if (inputString.Equals("start", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            } while (true);

            int massageCount = 0;
            string massageToEncrypt = null;
            do
            {
                massageToEncrypt = Console.ReadLine();
                if (massageToEncrypt.Equals("end", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (massageToEncrypt != "")
                {
                    massageCount++;
                    char[] charactersInMassage = massageToEncrypt.ToCharArray();
                    for (int i = 0; i < charactersInMassage.Length; i++)
                    {
                        charactersInMassage[i] = characterEncrypter(charactersInMassage[i]);
                    }
                    encryptedMassages.Add(charactersInMassage);
                }
            } while (true);

            if (massageCount == 0)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", massageCount);
                foreach (var massage in encryptedMassages)
                {
                    for (int i = massage.Length - 1; i >= 0; i--)
                    {
                        Console.Write(massage[i]);
                    }
                    Console.WriteLine();
                }
            }
        }

        static char characterEncrypter (char ch)
        {

            switch (ch)
            {
                case ' ': ch = '+'; break;
                case ',': ch = '%'; break;
                case '.': ch = '&'; break;
                case '?': ch = '#'; break;
                case '!': ch = '$'; break;
                default:
                    if ((ch >= 'A' && ch <= 'M') || (ch >= 'a' && ch <= 'm'))
                    {
                        ch = (char)(ch + 13);
                    }
                    else if ((ch >= 'N' && ch <= 'Z') || (ch >= 'n' && ch <= 'z'))
                    {
                        ch = (char)(ch - 13);
                    }
                    break;
            }
            return ch;
        }
    }
}
