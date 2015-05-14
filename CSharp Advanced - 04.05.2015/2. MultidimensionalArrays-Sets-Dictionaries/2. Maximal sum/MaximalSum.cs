using System;

class MaximalSum
{
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(new string[]{" "}, 
            StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(sizes[0]);
        int m = int.Parse(sizes[1]);
        int[,] matrix = new int[n,m];
        FillTheMatrix(matrix);
        int sizeX = 3;
        int sizeY = 3;
        int row = 0;
        int col = 0;
        int sum = 0;
        int bestSum = 0;
        for (int i = 0; i <= matrix.GetLength(0) - sizeX; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - sizeY; j++)
            {                
                sum = CalculateSubmatrixSum(matrix, i, j, sizeX);
                if (bestSum < sum)
                {
                    bestSum = sum;
                    row = i;
                    col = j;
                } 
            }
        }
        Console.Clear();
        Console.WriteLine("Sum = {0}", bestSum);
        for (int i = row; i < row + 3; i++)
        {
            for (int j = col; j < col + 3; j++)
                Console.Write("{0, 4}", matrix[i, j]);
            Console.WriteLine();
        }
    }

    private static int CalculateSubmatrixSum(int[,] matrix, int row, int col, int subMatrixLength)
    {
        int tempSum = 0;       
        for (int i = row; i < row + subMatrixLength; i++)
            for (int j = col; j < col + subMatrixLength; j++)
                tempSum += matrix[i, j];
        return tempSum;
    }

    private static void FillTheMatrix(int[,] matrix)
    {        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] inputRow = Console.ReadLine().Split(new string[]{" "}, 
                StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < matrix.GetLength(1); col++)            
                matrix[row, col] = int.Parse(inputRow[col]);            
        }
    }
}
