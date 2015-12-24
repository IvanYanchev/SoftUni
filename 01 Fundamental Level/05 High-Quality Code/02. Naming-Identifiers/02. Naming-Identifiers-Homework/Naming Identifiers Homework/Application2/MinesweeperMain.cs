using System;
using System.Collections.Generic;

namespace Minesweeper
{
    public class Minesweeper
    {
        private const int BoardHeight = 5;
        private const int BoardWidth = 10;

        private static void Main()
        {
            const int max = 35;
            
            string command = string.Empty;
            char[,] gameBoard = CreateGameBoard();
            char[,] mines = GenerateRandomMines();
            int pointsCount = 0;
            bool hasExploded = false;
            List<Score> scores = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool isNewGame = true;
            bool hasWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine(
                        "Let's play “Minesweeper”. Try your chance to find all the cells without mines."
                        + " Command 'top' displays the HihScores, 'restart' starts new game, 'exit' quits the game!");
                    DrawGameBoard(gameBoard);
                    isNewGame = false;
                }

                Console.Write("Type row and column : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= gameBoard.GetLength(0) && col <= gameBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetHighScores(scores);
                        break;
                    case "restart":
                        gameBoard = CreateGameBoard();
                        mines = GenerateRandomMines();
                        DrawGameBoard(gameBoard);
                        hasExploded = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye, bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                PlayersTurn(gameBoard, mines, row, col);
                                pointsCount++;
                            }

                            if (max == pointsCount)
                            {
                                hasWon = true;
                            }
                            else
                            {
                                DrawGameBoard(gameBoard);
                            }
                        }
                        else
                        {
                            hasExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command\n");
                        break;
                }

                if (hasExploded)
                {
                    DrawGameBoard(mines);
                    Console.Write("\nHrrrrrr! You've died with {0} points. " + "Enter your name: ", pointsCount);
                    string name = Console.ReadLine();
                    Score score = new Score(name, pointsCount);
                    if (scores.Count < 5)
                    {
                        scores.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < scores.Count; i++)
                        {
                            if (scores[i].Points < score.Points)
                            {
                                scores.Insert(i, score);
                                scores.RemoveAt(scores.Count - 1);
                                break;
                            }
                        }
                    }

                    scores.Sort((Score score1, Score score2) => score2.Name.CompareTo(score1.Name));
                    scores.Sort((Score score1, Score score2) => score2.Points.CompareTo(score1.Points));
                    GetHighScores(scores);

                    gameBoard = CreateGameBoard();
                    mines = GenerateRandomMines();
                    pointsCount = 0;
                    hasExploded = false;
                    isNewGame = true;
                }

                if (hasWon)
                {
                    Console.WriteLine("\nBRAVOOOOO! You've open all 35 cells!");
                    DrawGameBoard(mines);
                    Console.WriteLine("Enter your name, pal: ");
                    string name = Console.ReadLine();
                    Score score = new Score(name, pointsCount);
                    scores.Add(score);
                    GetHighScores(scores);
                    gameBoard = CreateGameBoard();
                    mines = GenerateRandomMines();
                    pointsCount = 0;
                    hasWon = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void GetHighScores(List<Score> scores)
        {
            Console.WriteLine("\nPoints:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, scores[i].Name, scores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty list!\n");
            }
        }

        private static void PlayersTurn(char[,] gameBoard, char[,] mines, int row, int col)
        {
            char numberOfMines = GetNumberOfNeighbourMines(mines, row, col);
            mines[row, col] = numberOfMines;
            gameBoard[row, col] = numberOfMines;
        }

        private static void DrawGameBoard(char[,] board)
        {
            int boardHeight = board.GetLength(0);
            int boardWidth = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardHeight; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardWidth; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int boardRows = BoardHeight;
            int boardColumns = BoardWidth;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] GenerateRandomMines()
        {
            int rows = BoardHeight;
            int columns = BoardWidth;
            char[,] mines = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mines[i, j] = '-';
                }
            }

            List<int> positions = new List<int>();
            while (positions.Count < 15)
            {
                Random random = new Random();
                int position = random.Next(50);
                if (!positions.Contains(position))
                {
                    positions.Add(position);
                }
            }

            foreach (int position in positions)
            {
                int col = position / columns;
                int row = position % columns;

                if (row == 0 && position != 0)
                {
                    col--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                mines[col, row - 1] = '*';
            }

            return mines;
        }

        private static void Calculations(char[,] gameBoard)
        {
            int col = gameBoard.GetLength(0);
            int row = gameBoard.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (gameBoard[i, j] != '*')
                    {
                        char numberOfNeighbourMines = GetNumberOfNeighbourMines(gameBoard, i, j);
                        gameBoard[i, j] = numberOfNeighbourMines;
                    }
                }
            }
        }

        private static char GetNumberOfNeighbourMines(char[,] mines, int row, int col)
        {
            int countNeighbourMines = 0;
            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, col] == '*')
                {
                    countNeighbourMines++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, col] == '*')
                {
                    countNeighbourMines++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[row, col - 1] == '*')
                {
                    countNeighbourMines++;
                }
            }

            if (col + 1 < cols)
            {
                if (mines[row, col + 1] == '*')
                {
                    countNeighbourMines++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[row - 1, col - 1] == '*')
                {
                    countNeighbourMines++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mines[row - 1, col + 1] == '*')
                {
                    countNeighbourMines++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mines[row + 1, col - 1] == '*')
                {
                    countNeighbourMines++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mines[row + 1, col + 1] == '*')
                {
                    countNeighbourMines++;
                }
            }

            return char.Parse(countNeighbourMines.ToString());
        }
    }
}