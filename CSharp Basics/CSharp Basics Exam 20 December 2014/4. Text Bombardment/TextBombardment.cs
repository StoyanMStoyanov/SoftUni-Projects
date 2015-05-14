using System;

class TextBombardment
{
    static void Main()
    {
        string text = Console.ReadLine();
        int columns = int.Parse(Console.ReadLine());
        var bombed = Console.ReadLine().Split(' ');
        int rows = 0;
        if (text.Length % columns != 0)
            rows = text.Length / columns + 1;
        else
            rows = text.Length / columns;
        char[,] matrix = new char[rows, columns]; 
        int index = 0;
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                if (index < text.Length)
                    matrix[r, c] = text[index];
                else
                    matrix[r, c] = ' ';
                index++;
                //Console.Write("{0} ", matrix[r, c]);//
            }
            //Console.WriteLine();//
        }
        int bombNumber = bombed.Length - 1;
        while (bombNumber >= 0)
        {
            int bombCol = int.Parse(bombed[bombNumber]);
            for (int row = 0; row < rows; row++)
            {
                if (matrix[row, bombCol] == ' ' && row != 0) break; //??????????????
                matrix[row, bombCol] = ' ';
            }

            bombNumber--;
        }
        //Console.WriteLine(new string('-', 30));//
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)     
                Console.Write("{0}", matrix[r, c]);
        }
        Console.WriteLine();
    }
}
