using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            inputLine = inputLine.ToUpper();

            char[] characters = inputLine.ToCharArray();
            int count = 0;
            int sum = 0;
            for (int i = 0; i < characters.Length; i++)
            {
                switch (characters[i])
                {
                    case 'A':
                        sum += 65;
                        count++;
                        break;
                    case 'E':
                        sum += 69;
                        count++;
                        break;
                    case 'I':
                         sum += 73;
                        count++;
                        break;
                    case 'O':
                        sum += 79;
                        count++;
                        break;
                    case 'U':
                        sum += 85;
                        count++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
