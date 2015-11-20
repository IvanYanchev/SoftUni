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
        private int capacity;
        private byte[] bitArray;

        private int Capacity
        {
            set
            {
                if (value < 1 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("The size of the array should be between 1 and 100 000 bits");
                }
                else
                {
                    this.capacity = value;
                }
            }
        }

        public BitArray(int capacity)
        {
            this.Capacity = capacity;
            this.bitArray = new byte[this.capacity];
        }

        public BitArray(params byte[] bits)
        {
            bitArray = new byte[bits.Length];

            for (int i = 0; i < bits.Length; i++)
            {
                bitArray[i] = bits[i];
            }
        }

        public BitArray(BigInteger number)
        {
            List<byte> bits = new List<byte>();

            while (true)
            {
                byte remainder = (byte)(number % 2);
                bits.Add(remainder);
                number /= 2;
                if (number == 0)
                {
                    break;
                }
            }

            this.bitArray = bits.ToArray();
        }

        public byte this[int index]
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
            if (index < 0 || index > this.bitArray.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            return this.bitArray[index];
        }

        private void SetBitAtIndex(int index, byte bit)
        {
            if (index < 0 || index > this.bitArray.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
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
            for (int i = 0; i < this.bitArray.Length; i++)
            {
                result += (BigInteger)(this.bitArray[i] * Math.Pow(2, i));
            }
            return result.ToString();
        }
    }
}
