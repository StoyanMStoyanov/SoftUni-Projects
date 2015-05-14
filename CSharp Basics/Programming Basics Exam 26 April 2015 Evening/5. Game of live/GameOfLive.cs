using System;

class GameOfLive
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] board = new int[10];
    
        for (int i = 0; i < n; i++)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            board[row] ^= (1 << col);
        }

        for (int j = 0; j < 10; j++)
        {
            int currentRow = board[j];
            int prevRow = (j != 0) ? board[j - 1] : 0;
            int nextRow = (j < 9) ? board[j + 1] : 0;

            int boardRow = 0;
            if (IsLive(prevRow, currentRow, nextRow, out boardRow))
                Console.WriteLine(IntToBinaryString(boardRow));
                //Console.WriteLine("{0,5} -> {1}", boardRow, IntToBinaryString(boardRow));
            //else Console.WriteLine(board[j]);
        }

        //foreach (var item in board)
        //    Console.WriteLine(item);
    }

    private static bool IsLive(int prevRow, int currentRow, int nextRow, out int value)
    {
        value = 0;
        int bit = 0;
        int neigborsCount = 0;
        bool changeNumber = false;
        int tempCurrentRow = currentRow;
        for (int i = 0; i < 10; i++)
        {
            neigborsCount = 0;
            bit = currentRow & (1 << i);
            for (int k = i-1; k <= i+1; k++)
            {
                if (k < 0 || k > 9) continue;
                if ((prevRow & (1 << k)) == 0) continue;
                neigborsCount++;
            }
            for (int k = i - 1; k <= i + 1; k++)
            {
                if (k < 0 || k > 9) continue;
                if ((nextRow & (1 << k)) == 0) continue;
                neigborsCount++;
            }
            int prevBit = (currentRow & 1 << (i - 1));
            if (i > 0) if (prevBit != 0) neigborsCount++;
            int nextBit = (currentRow & 1 << (i + 1));
            if (i < 9) if (nextBit != 0) neigborsCount++;

            if (neigborsCount < 2)
            {
                tempCurrentRow &= ~(1 << i); //-> 0                
                changeNumber = true;
            }
            else if (neigborsCount > 2)
            {
                if (bit == 0) tempCurrentRow |= (1 << i);
                else tempCurrentRow &= ~(1 << i);
            }
            
        }
        value = tempCurrentRow;
        return changeNumber;
    }
    private static string IntToBinaryString(int number)
    {
        string binary = string.Empty;
        while (number > 0)
        {
            binary = (number & 1) + binary;
            number >>= 1;
        }
        while (binary.Length < 10) binary = 0 + binary;
        return binary;
    }

    private static void PrintBoard(int[] board)
    {
        foreach (var row in board)
        {
            Console.WriteLine(Convert.ToString(row, 2).PadLeft(10, '0'));
        }        
    }
}
