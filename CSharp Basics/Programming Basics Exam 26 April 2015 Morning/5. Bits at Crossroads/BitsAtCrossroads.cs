using System;

class BitsAtCrossroads
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] board = new int[n];
        int points = 0;
        while (true)
        {
            string[] position = Console.ReadLine().Split(' ');
            if (position[0] == "end") break; 
            int row = int.Parse(position[0]);
            int col = int.Parse(position[1]);
            for (int i = 0; i < n; i++)
            {
                if (row == 0 || col == 0) break;
                else
                {
                    row--;
                    col++;
                }
            }
            //Console.WriteLine(row + " " + col);
            for (int i = row, j = col; i < n; i++, j--)
            {
                if (i > n || i < 0 || j > n || j < 0) break;
                if ((board[i] & (1 << j)) > 0) points++;
                board[i] |= (1 << j);
            }

            row = int.Parse(position[0]);
            col = int.Parse(position[1]);
            for (int i = 0; i < n; i++)
            {
                if (row == 0 || col == 0) break;
                else
                {
                    row--;
                    col--;
                }
            }
            //Console.WriteLine(row + " " + col);
            for (int i = row, j = col; i < n; i++, j++)
            {
                if (i > n || i < 0 || j >= n || j < 0) break;
                if ((board[i] & (1 << j)) > 0) points++;
                board[i] |= (1 << j);
            }
        }
        foreach (var item in board)
            Console.WriteLine(item);
        Console.WriteLine(points);
        

    }
}
