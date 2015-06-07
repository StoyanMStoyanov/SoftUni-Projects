using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TempTargetPractice
{
    static void Main()
    {
        var matrixSize = Console.ReadLine().Split(' ');
        string matrixContent = Console.ReadLine();
        var targetSize = Console.ReadLine().Split(' ');
        char[,] matrix = new char[int.Parse(matrixSize[0]), int.Parse(matrixSize[1])];
        FillMatrix(matrix, matrixContent);
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col]);
            }
            Console.WriteLine();
        }
    }

    private static void FillMatrix(char[,] matrix, string matrixContent)
    {
        bool isOpacity = false;
        int index = 0;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            isOpacity = !isOpacity;
            if (isOpacity)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    matrix[row,col] = matrixContent[index];
                    index++;
                    if (index == matrixContent.Length) index = 0;
                }
            }
            else
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixContent[index];
                    index++;
                    if (index == matrixContent.Length) index = 0;
                }
            }
        }
    }
}