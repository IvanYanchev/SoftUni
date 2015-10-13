using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Encrypted_matrix
{
    class EncryptedMatrix
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string inputAsNumber = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                inputAsNumber += input[i] % 10;
            }

            string encryptedNumber = string.Empty;

            for (int i = 0; i < inputAsNumber.Length; i++)
            {
                int digit = int.Parse(inputAsNumber[i].ToString());
                if (digit % 2 == 0)
                {
                    digit *= digit;
                }
                else
                {
                    int prevDigit = 0;
                    int nextDigit = 0;
                    if (i - 1 >= 0)
	                {
                        prevDigit = int.Parse(inputAsNumber[i - 1].ToString());
	                }
                    if (i + 1 < inputAsNumber.Length)
                    {
                        nextDigit = int.Parse(inputAsNumber[i + 1].ToString());
                    }

                    digit += prevDigit + nextDigit;
                }

                encryptedNumber += digit;
            }

            string diagonal = Console.ReadLine();

            for (int i = 0; i < encryptedNumber.Length; i++)
            {
                char[] matrixLine = new char[encryptedNumber.Length];
                for (int j = 0; j < matrixLine.Length; j++)
                {
                    matrixLine[j] = '0';
                }

                int position = i;
                if (diagonal == "/")
                {
                    position = matrixLine.Length - 1 - i;
                }
                matrixLine[position] = encryptedNumber[position];

                Console.WriteLine(string.Join(" ", matrixLine));
            }
        }
    }
}
