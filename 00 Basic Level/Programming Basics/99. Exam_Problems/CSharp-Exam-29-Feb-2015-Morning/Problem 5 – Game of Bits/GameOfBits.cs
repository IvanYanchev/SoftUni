using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Game_of_Bits
{
    class GameOfBits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            do
            {
                string command = Console.ReadLine();

                if (command == "Game Over!")
                {
                    break;
                }

                int startPosition = 0;

                if (command == "Even")
                {
                    startPosition = 1;
                }

                uint newNumber = 0;
                int positionBitInNewNumber = 0;

                for (int position = startPosition; position < 32; position += 2)
                {
                    uint bit = (number >> position) & 1;
                    newNumber = newNumber | (bit << positionBitInNewNumber);
                    positionBitInNewNumber++;
                }

                number = newNumber;

            } while (true);

            int bitCount = 0;
            for (int i = 0; i < 32; i++)
            {
                if (((number >> i) & 1) == 1)
                {
                    bitCount++;
                }
            }

            Console.WriteLine("{0} -> {1}", number, bitCount);
        }
    }
}
