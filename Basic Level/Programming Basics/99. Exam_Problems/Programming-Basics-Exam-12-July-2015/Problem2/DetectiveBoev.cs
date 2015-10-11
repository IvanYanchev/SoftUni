using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveBoev
{
    class DetectiveBoev
    {
        static void Main(string[] args)
        {
            string secretWord = Console.ReadLine();
            string encrtyptedMessage = Console.ReadLine();

            int mask = 0;
            for (int i = 0; i < secretWord.Length; i++)
            {
                mask += secretWord[i];
            }

            while (true)
            {
                if (mask > 9)
                {
                    string maskToString = mask.ToString();
                    mask = 0;
                    for (int i = 0; i < maskToString.Length; i++)
                    {
                        mask += int.Parse(maskToString[i].ToString());
                    }
                }
                else
                {
                    break;
                }
            }

            string decryptedMessage = string.Empty;

            for (int j = 0; j < encrtyptedMessage.Length; j++)
            {
                char decryptedSymbol;
                char encryptedSymbol = encrtyptedMessage[j];
                if (encryptedSymbol % mask == 0)
                {
                    decryptedSymbol = (char)(encrtyptedMessage[j] + mask);
                }
                else
                {
                    decryptedSymbol = (char)(encrtyptedMessage[j] - mask);
                }

                decryptedMessage = decryptedSymbol + decryptedMessage;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
