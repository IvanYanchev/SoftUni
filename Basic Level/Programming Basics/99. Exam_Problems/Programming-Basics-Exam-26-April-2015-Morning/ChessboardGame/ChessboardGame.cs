using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardGame
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            char[] chessboard = new char[size * size];
            int sumBlack = 0;
            int sumWhite = 0;

            int i = 0;
            while (i < chessboard.Length && i < inputString.Length)
            {
                chessboard[i] = inputString.ElementAt(i);
                if ((chessboard[i] >= 48 && chessboard[i] <= 57) || (chessboard[i] >= 97 && chessboard[i] <= 122))
                {
                    switch (i % 2)
                    {
                        case 0: sumBlack += chessboard[i]; break;
                        case 1: sumWhite += chessboard[i]; break;
                    }
                }
                else if (chessboard[i] >= 65 && chessboard[i] <= 90)
                {
                    switch (i % 2)
                    {
                        case 0: sumWhite += chessboard[i]; break;
                        case 1: sumBlack += chessboard[i]; break;
                    }
                }
                i++;
            }


            if (sumBlack != sumWhite)
            {
                switch (sumBlack>sumWhite)
                {
                    case true: Console.WriteLine("The winner is: {0} team", "black"); break;
                    case false: Console.WriteLine("The winner is: {0} team", "white"); break;
                }

                Console.WriteLine(Math.Max(sumBlack, sumWhite) - Math.Min(sumBlack,sumWhite));
            }
            else
            {
                Console.WriteLine("Equal result: {0}", sumBlack);
            }
        }
    }
}
