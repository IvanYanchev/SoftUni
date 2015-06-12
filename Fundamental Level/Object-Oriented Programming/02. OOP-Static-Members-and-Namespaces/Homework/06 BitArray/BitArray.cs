using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitArray
{
    public class BitArray
    {
        private List<byte> bitArray = null;

        public BitArray(params byte[] bits)
        {
            bitArray = new List<byte>();

            foreach (byte bit in bits)
            {
                bitArray.Add(bit);
            }
        }

        public BitArray(BigInteger number)
        {
            bitArray = new List<byte>();

            while (true)
            {
                BigInteger result = number / 2;
                byte remainder = (byte)(number % 2);
                this.bitArray.Add(remainder);
                if (result == 0)
                {
                    break;
                }

                number = result;
            }
        }

        public byte this [int index]
        {
            get
            {
                return this.GetBitAtIndex(index);
            }
            set
            {
                this.SetBitAtIndex(index, value);
            }
        }

        private byte GetBitAtIndex(int index)
        {
            if (index < 0 || index > this.bitArray.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            return this.bitArray[index];
        }

        private void SetBitAtIndex(int index, byte bit)
        {
            if (index < 0 || index > this.bitArray.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }
            if (bit != 0 && bit != 1)
            {
                throw new ArgumentException("A bit can be only 0 or 1.");
            }
            this.bitArray[index] = bit;
        }

        //public override string ToString()
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = 0; i < this.bitArray.Count; i++)
        //    {
        //        result.Append(bitArray[i]);
        //    }
        //    return result.ToString();
        //}

        public override string ToString()
        {
            BigInteger result = 0;
            for (int i = 0; i < this.bitArray.Count; i++)
            {
                result += (BigInteger)(this.bitArray[i] * Math.Pow(2, i));
            }
            return result.ToString();
        }
    }
}
