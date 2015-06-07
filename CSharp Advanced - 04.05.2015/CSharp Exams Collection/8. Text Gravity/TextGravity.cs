using System;
using System.Collections.Generic;
using System.Security;

class TextGravity
{
    static void Main()
    {
        int matrixCols = int.Parse(Console.ReadLine());
        string inputText = Console.ReadLine();
        int matrixRows = inputText.Length / matrixCols;
        if (inputText.Length % matrixCols != 0) matrixRows++;
        char[,] matrix = new char[matrixRows, matrixCols];
        int index = 0;
        for (int i = 0; i < matrixRows; i++)
        {
            for (int j = 0; j < matrixCols; j++)
            {
                if (index < inputText.Length)
                {
                    matrix[i, j] = inputText[index];
                    index++;
                }
                else matrix[i, j] = ' ';
            }
        }
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
                if(matrix[row,col] == ' ' && matrix[row-1,col] != ' ')
                {
                    matrix[row, col] = matrix[row - 1, col];
                    isMove = true;
                    matrix[row - 1, col] = ' ';
                }
            }
        }
    }

    private static void PrintMatrix(char[,] matrix)
    {
        Console.Write("<table>");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.Write("<tr>");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("<td>{0}</td>", SecurityElement.Escape(matrix[i,j].ToString()));
            }
            Console.Write("</tr>");
        }
        Console.Write("</table>");
        Console.WriteLine();
    }
}
