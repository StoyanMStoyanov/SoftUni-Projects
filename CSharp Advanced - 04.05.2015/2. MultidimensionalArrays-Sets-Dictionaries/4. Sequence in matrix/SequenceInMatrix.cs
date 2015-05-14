using System;

class SequenceInMatrix
{
    static void Main()
    {
        string[,] matrix = {                                 
                                {"ha", "fifi", "ho", "xx"},
                                {"fo", "ha", "hi", "xx"},
                                {"xx", "ho", "ha", "xx"},
                           };
        string[,] matrix1 = {   
                                {"ha", "ha", "ha", "ha"},
                                {"ha", "fifi", "ho", "xx"},
                                {"fo", "ha", "hi", "xx"},
                                {"xx", "ho", "ha", "xx"},
                           };
        //Search Horizontal
        string temp = string.Empty;
        int count = 0;
        for (int row = 0; row < matrix1.GetLength(0); row++)
        {
            temp = matrix1[row, 0];
            count = 1;
            for (int col = 1; col < matrix1.GetLength(1); col++)
                if (matrix1[row, col] == temp)
                    count++;
            if(count == matrix1.GetLength(0)) break;                
        }

        //Print Result - horizontal
        Console.Write("Horizontal search:  ");
        for (int index = 0; index < count; index++)
        {
            Console.Write(temp);
            if (index != count - 1) Console.Write(", ");
        }
        Console.WriteLine();

        //Search Vertical
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            temp = matrix[0, col];
            count = 1;
            for (int row = 1; row < matrix.GetLength(0); row++)
                if (matrix[row, col] == temp)
                    count++;
            if (count == matrix.GetLength(1)) break;
        }

        //Search Diagonal
        /*
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            temp = matrix[row, 0];
            count = 1;
            for (int col = 1; col < matrix.GetLength(1); col++)
                if (matrix[row, col] == temp)
                    count++;
            if (count == matrix.GetLength(0)) break;
        }*/

        //Print Result - vertical
        Console.Write("Vertical search:  ");
        for (int index = 0; index < count; index++)
        {
            Console.Write(temp);
            if (index != count - 1) Console.Write(", ");                
        }
        Console.WriteLine();
    }

   
}
