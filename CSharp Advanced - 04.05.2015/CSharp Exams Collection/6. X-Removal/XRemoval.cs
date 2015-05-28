using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class XRemoval
{
    static void Main()
    {
        List<string> inputData = new List<string>();
        string line = string.Empty;
        int length = 0;
        while (true)
        {
            line = Console.ReadLine();
            if (line == "End" | line == "end" | line == "END") break;
            inputData.Add(line);
            if (length < line.Length) length = line.Length;
        }
        char[,] matrix = new char[inputData.Count, length];
        for (var row = 0; row < matrix.GetLength(0); row++)
        {
            line = inputData[row];
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col < line.Length)
                    matrix[row, col] = line[col];
                else
                    matrix[row, col] = char.MinValue;
            }
        }

        char[,] outputMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
        for (var row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                char temp = char.ToLower(matrix[row, col]);
                if (char.ToLower(matrix[row, col]) == temp
                    & char.ToLower(matrix[row, col + 2]) == temp
                    & char.ToLower(matrix[row + 1, col + 1]) == temp
                    & char.ToLower(matrix[row + 2, col]) == temp
                    & char.ToLower(matrix[row + 2, col + 2]) == temp)
                {
                    outputMatrix[row, col] = temp;
                    outputMatrix[row, col + 2] = temp;
                    outputMatrix[row + 1, col + 1] = temp;
                    outputMatrix[row + 2, col] = temp;
                    outputMatrix[row + 2, col + 2] = temp;
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (outputMatrix[row, col] == char.MinValue)
                    Console.Write(matrix[row, col]);
                
            }
            Console.WriteLine();
        }
    }
}
