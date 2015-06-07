using System;
using System.Collections.Generic;

class TargetPractice
{
    static void Main()
    {
        string[] line = Console.ReadLine().Split(' ');
        char[,] matrix = new char[int.Parse(line[0]), int.Parse(line[1])];
        string inputStr = Console.ReadLine();
        var coordinates = Console.ReadLine().Split();
        

        FillData(matrix, inputStr);
        Point(matrix, coordinates);
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            MoveDown(matrix, col);
        }
        PrintMatrix(matrix);
        
    }

    private static void MoveDown(char[,] matrix, int col)
    {
        bool isMove = true;
        while (isMove)
        {
            isMove = false;
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, col] == ' ' && matrix[row - 1, col] != ' ')
                {
                    matrix[row, col] = matrix[row - 1, col];
                    isMove = true;
                    matrix[row - 1, col] = ' ';
                }
            }
        }
    }

    private static void Point(char[,] matrix, string[] coordinates)
    {
        int rowCenter = int.Parse(coordinates[0]);
        int colCenter = int.Parse(coordinates[1]);
        int radius = int.Parse(coordinates[2]);
        int row = rowCenter-radius;
        int col = colCenter - radius;
        if (row < 0) row = 0;
        if (col < 0) col = 0;
        int rowEnd = rowCenter + radius;
        int colEnd = colCenter + radius;
        if (rowEnd >= matrix.GetLength(0)) rowEnd = matrix.GetLength(0);
        if (colEnd >= matrix.GetLength(1)) rowEnd = matrix.GetLength(1);
        int startindex = colCenter;
        int endIndex = colCenter;
        for (int i = row; i <= rowCenter; i++)
        {            
            for (int j = startindex; j <= endIndex; j++)
            {
                matrix[i, j] = ' ';                              
            }
            startindex--;
            endIndex++;
            if (startindex < col) break;
        }
        startindex = colCenter - radius + 1;
        endIndex = colCenter + radius - 1;
        for (int i = rowCenter+1; i <= rowEnd; i++)
        {
            for (int j = startindex; j <= endIndex; j++)
            {
                matrix[i, j] = ' ';
            }
            startindex++;
            endIndex--;
            if (startindex < col) break;
        }
        
    }    

    private static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void FillData(char[,] matrix, string inputText)
    {
        int index = 0;
        bool isOpacue = true;
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            if (isOpacue)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    if (index == inputText.Length) index = 0;
                    matrix[i, j] = inputText[index];
                    index++;
                }
            }
            else
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (index == inputText.Length) index = 0;
                    matrix[i, j] = inputText[index];
                    index++;
                }
            }
            isOpacue = !isOpacue;
        }
    }
}
    

