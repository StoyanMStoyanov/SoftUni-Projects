using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter size of matrix: ");
        int matrixSize = int.Parse(Console.ReadLine());
        for (int row = 1; row <= matrixSize; row++)
        {
            for (int col = row; col < row + matrixSize; col++)
                Console.Write("{0, 3}", col);

            Console.WriteLine();
        }
    }
}
