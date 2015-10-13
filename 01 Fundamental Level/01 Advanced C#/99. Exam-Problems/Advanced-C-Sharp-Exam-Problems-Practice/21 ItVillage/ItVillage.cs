using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItVillage
{
    public class Player
    {
        private int positionRow = 0;
        private int positionCol = 0;
        private int innsOwned = 0;
        private int coins = 50;
        private int skipMoves = 0;
        private bool win = false;

        public Player (int startPositionRow, int startPositionCol)
        {
            this.PositionRow = startPositionRow;
            this.PositionCol = startPositionCol;
        }

        public int PositionRow
        {
            get { return this.positionRow; }
            set { this.positionRow = value; }
        }
        public int PositionCol
        {
            get { return this.positionCol; }
            set { this.positionCol = value; }
        }
        public int InnsOwned
        { 
            get { return this.innsOwned; }
            set { this.innsOwned = value; }
        }
        public int Coins
        {
            get { return this.coins; }
            set { this.coins = value; }
        }
        public int SkipMoves 
        { 
            get { return this.skipMoves; }
            set {this.skipMoves = value; }
        }
        public bool Win 
        {
            get { return this.win; }
            set { this.win = value; } 
        }
    }

    class ItVillage
    {
        static void Main(string[] args)
        {
            string[,] board = new string[4, 4];

            string inputBoardLine = Console.ReadLine();
            int totalNumberOfInns = inputBoardLine.Count(x => x == 'I');

            string[] boardLines = inputBoardLine.Split('|');

            for (int i = 0; i < board.GetLength(0); i++)
            {
                string[] chars = boardLines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = chars[j];
                }
            }

            int[] enteringPosition = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Player player = new Player(enteringPosition[0] - 1, enteringPosition[1] - 1);

            int[] moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < moves.Length; i++)
            {
                if (player.Win)
                {
                    Console.WriteLine("<p>You won! Nakov's force was with you!<p>");
                    return;
                }
                else if (player.Coins <= 0)
                {
                    Console.WriteLine("<p>You lost! You ran out of money!<p>");
                    return;
                }
                else if (player.SkipMoves > 0)
                {
                    player.SkipMoves--;
                }
                else if (player.InnsOwned == totalNumberOfInns)
                {
                    Console.WriteLine("<p>You won! You own the village now! You have {0} coins!<p>", player.Coins);
                    return;
                }
                else
                {
                    MoveToNewPosition(player, board, moves[i]);
                }
            }
            Console.WriteLine("<p>You lost! No more moves! You have {0} coins!<p>", player.Coins);
        }


        static Player MoveToNewPosition(Player player, string[,] board, int moves)
        {
            player.Coins += player.InnsOwned * 20;

            for (int i = 0; i < moves; i++)
            {
                if (player.PositionRow == 0 && player.PositionCol < board.GetLength(1) - 1)
                {
                    player.PositionCol++;
                }
                else if (player.PositionRow < board.GetLength(0) - 1 && player.PositionCol == board.GetLength(1) - 1)
                {
                    player.PositionRow++;
                }
                else if (player.PositionRow == board.GetLength(0) - 1 && player.PositionCol > 0)
                {
                    player.PositionCol--;
                }
                else if (player.PositionRow > 0 && player.PositionCol == 0)
                {
                    player.PositionRow--;
                }
            }

            switch (board[player.PositionRow, player.PositionCol])
            {
                case "P":
                    {
                        player.Coins -= 5;
                        break;
                    }
                case"I":
                    {
                        if (player.Coins > 100)
                        {
                            player.Coins -= 100;
                            player.InnsOwned++;
                        }
                        else
                        {
                            player.Coins -= 10;
                        }
                        break;
                    }
                case "F":
                    {
                        player.Coins += 20;
                        break;
                    }
                case "S":
                    {
                        player.SkipMoves = 2;
                        break;
                    }
                case "V":
                    {
                        player.Coins = player.Coins * 10;
                        break;
                    }
                case "N":
                    {
                        player.Win = true;
                        break;
                    }
            }

            return player;
        }
    }
}
