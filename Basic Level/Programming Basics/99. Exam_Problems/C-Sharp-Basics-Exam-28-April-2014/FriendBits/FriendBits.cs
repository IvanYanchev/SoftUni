using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendBits
{
    class FriendBits
    {
        static uint AddToBits(uint groupOfBits, uint bit, int position)
        {
            switch (bit)
            {
                case 0:
                    break;
                case 1:
                    groupOfBits = groupOfBits | (1u << position);
                    break;
            }
            return groupOfBits;
        }

        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint friebdBits = 0;
            uint aloneBits = 0;
            int positionFriendBits = 0;
            int positionAloneBits = 0;
            uint bitAtPosition = 0;
            uint bitAtPreviousPosition = 0;
            uint bitAtNextPosition = 0;
            

            for (int i = 0; i < 32; i++)
            {
                switch (i)
                {
                    case 0:
                        bitAtPosition = n & 1;
                        bitAtNextPosition = (n & 1u << 1) >> 1;
                        if (bitAtPosition == bitAtNextPosition)
                        {
                            friebdBits = AddToBits(friebdBits, bitAtPosition, positionFriendBits);
                            positionFriendBits++;
                        }
                        else
                        {
                            aloneBits = AddToBits(aloneBits, bitAtPosition, positionAloneBits);
                            positionAloneBits++;
                        }
                        break;
                    case 31:
                        bitAtPosition = (n & (1u << 31)) >> 31;
                        bitAtPreviousPosition = (n & 1u << 30) >> 30;
                        if (bitAtPosition == bitAtPreviousPosition)
                        {
                            friebdBits = AddToBits(friebdBits, bitAtPosition, positionFriendBits);
                            positionFriendBits++;
                        }
                        else
                        {
                            aloneBits = AddToBits(aloneBits, bitAtPosition, positionAloneBits);
                            positionAloneBits++;
                        }
                        break;
                    default:
                        bitAtPosition = (n & 1u << i) >> i;
                        bitAtPreviousPosition = (n & 1u << (i - 1)) >> (i - 1);
                        bitAtNextPosition = (n & 1u << (i + 1)) >> (i + 1);
                        if (bitAtPosition == bitAtPreviousPosition || bitAtPosition == bitAtNextPosition)
                        {
                            friebdBits = AddToBits(friebdBits, bitAtPosition, positionFriendBits);
                            positionFriendBits++;
                        }
                        else
                        {
                            aloneBits = AddToBits(aloneBits, bitAtPosition, positionAloneBits);
                            positionAloneBits++;
                        }
                        break;
                }
            }
            Console.WriteLine(friebdBits);
            Console.WriteLine(aloneBits);
        }
    }
}
