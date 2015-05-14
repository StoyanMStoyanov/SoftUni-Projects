using System;

class PaintBall
{
    static void Main()
    {
        int[] matrix = new int[10];
        for (var i = 0; i < 10;i++ )
            matrix[i] = 1023;
        int row = 0;
        int col = 0;
        int bit = 0; //0 set 0; 1 set 1
        while (true)
        {
            var inputStr = Console.ReadLine().Split(' ');
            if (inputStr[0] == "End") break;
            int radius = int.Parse(inputStr[2]);
            int diameter = 2 * radius + 1;
            row = int.Parse(inputStr[0]) - radius;
            int razlikaRow = 0;
            if (row < 0)
            {
                razlikaRow = row - 0; 
                row = 0;
            }
            col = int.Parse(inputStr[1]) - radius;
            int razlikaCol = 0;
            if (col < 0)
            {
                razlikaCol = col - 0;
                col = 0;
            }
            
            for (int r = row; r < row + diameter + razlikaRow; r++)
            {
                if (r > matrix.Length - 1) break;
                for (int c = col; c < diameter + col+razlikaCol; c++)
                {
                    if (c > matrix.Length - 1) break;
                    if (bit == 1) matrix[r] |= 1 << c;   //Set bits at 1
                    else matrix[r] &= ~(1 << c);         //Set bits at 0
                }                
            }
            if (bit == 0) bit = 1;
            else bit = 0;
        }
        int matrixSum = 0;
        foreach (var element in matrix)
            matrixSum += element;
        Console.WriteLine(matrixSum);
    }
}
