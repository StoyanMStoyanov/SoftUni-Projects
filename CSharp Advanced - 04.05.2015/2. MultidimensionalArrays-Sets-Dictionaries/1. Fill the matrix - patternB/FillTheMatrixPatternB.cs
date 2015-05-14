using System;
using System.Collections.Generic;

class FillTheMatrixPatternB
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = 1;
        int[,] matrix = new int[n, n];
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = temp;
                    temp++;
                }
            else
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = temp;
                    temp++;
                }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
                Console.Write("{0, 4}", matrix[i, j]);
            Console.WriteLine();
        }
    }
}

/*
 * for (int row = 0; row < n; row++)
        {
            temp = row + 1;
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,4}", temp);
                if (col % 2 == 0) temp = ((2 + col) * n) - row;
                else temp = temp = ((2 + col) * n);
            }
                Console.WriteLine();            
        }
*/