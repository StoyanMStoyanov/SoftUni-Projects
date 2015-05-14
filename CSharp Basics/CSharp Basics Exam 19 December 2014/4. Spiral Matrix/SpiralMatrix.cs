using System;

class SpiralMatrix
{
    static void Main()
    {
        //Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        string keyword = Console.ReadLine().ToLower();
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = n * n;
        int temp = 0;

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && row < 0 || matrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            //matrix[row, col] = i;
            
            matrix[row,col] = keyword[temp];            //Towa e moe
            if (temp == keyword.Length - 1) temp = 0;   //Towa e moe
            else temp++;                                //Towa e moe

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }

        // Display Matrix
        int rowSum = 0;
        int bestRow = 0;
        int bestSum = 0;
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                //Console.Write("{0,4}", (char)matrix[r, c]);
                rowSum += (matrix[r, c] - 96);               
            }
            if (bestSum < rowSum)
            {
                bestSum = rowSum;
                bestRow = r;
            }
            
            //Console.WriteLine("    {0}", rowSum);
            rowSum = 0;
        }
        Console.WriteLine();
        Console.WriteLine("{0} - {1}", bestRow, bestSum * 10);
    }
}