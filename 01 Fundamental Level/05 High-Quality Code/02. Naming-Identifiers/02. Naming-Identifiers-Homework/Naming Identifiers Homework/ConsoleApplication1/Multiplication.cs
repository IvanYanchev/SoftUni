using System;

namespace Matrices
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            var firstMatrix = new double[,] { { 1, 3 }, { 5, 7 } };
            var secondMatrix = new double[,] { { 4, 2 }, { 1, 5 } };
            var resultMatrix = MultiplyTwoMatrices(firstMatrix, secondMatrix);

            for (int resultmatrixRow = 0; resultmatrixRow < resultMatrix.GetLength(0); resultmatrixRow++)
            {
                for (int resultMatrixCol = 0; resultMatrixCol < resultMatrix.GetLength(1); resultMatrixCol++)
                {
                    Console.Write(resultMatrix[resultmatrixRow, resultMatrixCol] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MultiplyTwoMatrices(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var firstMatrixWidth = firstMatrix.GetLength(1);
            var resultMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
            for (int resultMatrixRow = 0; resultMatrixRow < resultMatrix.GetLength(0); resultMatrixRow++)
                for (int resultmatrixCol = 0; resultmatrixCol < resultMatrix.GetLength(1); resultmatrixCol++)
                    for (int firstMatrixCol = 0; firstMatrixCol < firstMatrixWidth; firstMatrixCol++)
                        resultMatrix[resultMatrixRow, resultmatrixCol] += firstMatrix[resultMatrixRow, firstMatrixCol] * secondMatrix[firstMatrixCol, resultmatrixCol];
            return resultMatrix;
        }
    }
}