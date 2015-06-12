using System;

    class FunWithMatrices
    {
        static void Main()
        {
            double[,] matrix = new double[4, 4];
            double startValue = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                if (i > 0)
                {
                    startValue = matrix[i - 1, 3] + step;
                }
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = startValue + j * step;
                }
            }

            bool gameOver = false;
            do
            {
                string commandLine = Console.ReadLine();
                if (commandLine != "Game Over!")
                {
                    string[] commands = commandLine.Split(' ');
                    int row = int.Parse(commands[0]);
                    int col = int.Parse(commands[1]);
                    double num = double.Parse(commands[3]);

                    switch (commands[2])
                    {
                        case "multiply":
                            matrix[row, col] *= num; break;
                        case "sum":
                            matrix[row, col] += num; break;
                        case "power":
                            matrix[row, col] = Math.Pow(matrix[row, col], num); break;
                    }
                }
                else
                {
                    gameOver = true;
                }

            } while (!gameOver);

            double sumLeftDiagonal = 0;
            double sumRightDiagonal = 0;
            double maxSumIndex = double.MinValue;
            string index = null;

            for (int i = 0; i < 4; i++)
            {
                double sumIndexRow = 0;
                double sumIndexCol = 0;
                for (int j = 0; j < 4; j++)
                {
                    sumIndexRow = sumIndexRow + matrix[i, j];
                    sumIndexCol = sumIndexCol + matrix[j, i];
                    if (i == j)
                    {
                        sumLeftDiagonal = sumLeftDiagonal + matrix[i, j];
                    }
                    if (i == j + 3)
                    {
                        sumRightDiagonal = sumRightDiagonal + matrix[i, j];
                    }
                }
                if (sumIndexRow > maxSumIndex)
                {
                    maxSumIndex = sumIndexRow;
                    index = "ROW[" + i + "]";
                }
                if (sumIndexCol > maxSumIndex)
                {
                    maxSumIndex = sumIndexCol;
                    index = "COLUMN[" + i + "]";
                }
                if (sumLeftDiagonal > maxSumIndex)
                {
                    maxSumIndex = sumLeftDiagonal;
                    index = "LEFT-DIAGONAL";
                }
                if (sumRightDiagonal > maxSumIndex)
                {
                    maxSumIndex = sumRightDiagonal;
                    index = "RIGHT-DIAGONAL";
                }
            }

            Console.WriteLine("{0} = {1:F2}", index, maxSumIndex);

        }
    }