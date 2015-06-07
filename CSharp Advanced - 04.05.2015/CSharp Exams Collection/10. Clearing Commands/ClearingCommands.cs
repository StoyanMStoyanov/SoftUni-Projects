using System;
using System.Collections.Generic;
using System.Security;

class ClearingCommands
{
    static void Main()
    {
        List<string> inputStr = new List<string>();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end" | line == "END" | line == "End") break;
            inputStr.Add(line);
        }
        char[,] matrix =new char[inputStr.Count, inputStr[0].Length];
        for (int row = 0; row < inputStr.Count; row++)
	    {
            string line = inputStr[row];
            for (int col = 0; col < line.Length; col++)
            {
                matrix[row, col] = line[col];
            }
        }
        char direction = char.MinValue;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                direction = matrix[row, col];
                if (direction != '<' & direction != '>' & direction != '^' & direction != 'v') continue;
                Clear(matrix, row, col, direction);
            }
        }
        PrintMatrix(matrix);
    }

    private static void Clear(char[,] matrix, int currentRow, int currentCol, char direction)
    {
        switch (direction)
        {
            case '>':
                for (int col = currentCol + 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[currentRow, col] != '<'
                        & matrix[currentRow, col] != 'v'
                        & matrix[currentRow, col] != '^')
                    {
                        matrix[currentRow, col] = ' ';
                    }
                    else break;
                }
                break;
            case '<':
                for (int col = currentCol - 1; col >= 0; col--)
                {
                    if (matrix[currentRow, col] != '>'
                        & matrix[currentRow, col] != 'v'
                        & matrix[currentRow, col] != '^')
                    {
                        matrix[currentRow, col] = ' ';
                    }
                    else break;
                }
                break;
            case '^':
                for (int row = currentRow - 1; row >= 0; row--)
                {
                    if (matrix[row, currentCol] != '<'
                        & matrix[row, currentCol] != 'v'
                        & matrix[row, currentCol] != '>')
                    {
                        matrix[row, currentCol] = ' ';
                    }
                    else break;
                }
                break;
            case 'v':
                for (int row = currentRow + 1; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, currentCol] != '<'
                        & matrix[row, currentCol] != '^'
                        & matrix[row, currentCol] != '>')
                    {
                        matrix[row, currentCol] = ' ';
                    }
                    else break;
                }
                break;
            default:
                break;
        }
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write("<p>");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(SecurityElement.Escape(matrix[row,col].ToString()));
            }
            Console.WriteLine("</p>");
        }
    }
    
}
