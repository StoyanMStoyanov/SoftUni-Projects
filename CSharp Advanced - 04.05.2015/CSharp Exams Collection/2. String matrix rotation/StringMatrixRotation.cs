using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class StringMatrixRotation
{
    static void Main()
    {
        int rotate = int.Parse(Regex.Match(Console.ReadLine(), @"\d+").ToString()) % 360;
        List<string> inputMatrix = new List<string>();
        int maxLength = 0;
        int count = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END" | input == "End" | input == "end") break;
            inputMatrix.Add(input);
            if (maxLength < input.Length) maxLength = input.Length;
            count++;
        }
        char[,] arrayOfChars = new char[count, maxLength];
        for (int i = 0; i < arrayOfChars.GetLength(0); i++)
        {
            string temp = inputMatrix[i];
            for (int j = 0; j < temp.Length; j++)
                arrayOfChars[i, j] = temp[j];
        }
        switch (rotate)
        {
            case 0:
                RotateMatrix0Degreess(arrayOfChars);
                break;
            case 1:
            case 90:
                RotateMatrix90Degrees(arrayOfChars);
                break;
            case 2:
            case 180:
                RotateMatrix180Degreess(arrayOfChars);
                break;
            case 3:
            case 270:
                RotateMatrix270Degreess(arrayOfChars);
                break;
            default:
                break;
        }
    }

    private static void RotateMatrix0Degreess(char[,] arrayOfChars)
    {
        PrintMatrix(arrayOfChars);
    }    
    private static void RotateMatrix90Degrees(char[,] arrayOfChars)
    {
        List<char> temp = new List<char>();
        char[,] outputMatrix = new char[arrayOfChars.GetLength(1),arrayOfChars.GetLength(0)];
        int col = outputMatrix.GetLength(1) - 1;
        for (int i = 0; i < arrayOfChars.GetLength(0); i++)
        {
            for (int j = 0; j < arrayOfChars.GetLength(1); j++)
            {
                if (arrayOfChars[i, j] == char.MinValue) temp.Add(' ');
                else temp.Add(arrayOfChars[i, j]);
            }
            for (int row = 0; row < outputMatrix.GetLength(0); row++)
            {
                outputMatrix[row, col] = temp[row];
            }
            temp.Clear();
            col--;
        }
        PrintMatrix(outputMatrix);
    }
    private static void RotateMatrix180Degreess(char[,] arrayOfChars)
    {
        List<char> temp = new List<char>();
        char[,] outputMatrix = new char[arrayOfChars.GetLength(0), arrayOfChars.GetLength(1)];
        //int col = outputMatrix.GetLength(1) - 1;
        for (int row = 0; row < arrayOfChars.GetLength(0); row++)
        {
            for (int col = 0; col < arrayOfChars.GetLength(1); col++)
            {
                outputMatrix[outputMatrix.GetLength(0) - row - 1, outputMatrix.GetLength(1) - col - 1] = arrayOfChars[row, col];
            }
        }
        PrintMatrix(outputMatrix);
    }
    private static void RotateMatrix270Degreess(char[,] arrayOfChars)
    {
        List<char> temp = new List<char>();
        char[,] outputMatrix = new char[arrayOfChars.GetLength(1), arrayOfChars.GetLength(0)];
        int col = 0;
        for (int i = 0; i < arrayOfChars.GetLength(0); i++)
        {
            for (int j = 0; j < arrayOfChars.GetLength(1); j++)
            {
                if (arrayOfChars[i, j] == char.MinValue) temp.Add(' ');
                else temp.Add(arrayOfChars[i, j]);
            }
            for (int row = outputMatrix.GetLength(0) - 1, index = 0; row >= 0; row--, index++)
            {
                outputMatrix[row, col] = temp[index];
            }
            temp.Clear();
            col++;
        }
        PrintMatrix(outputMatrix);
    }

    private static void PrintMatrix(char[,] outputMatrix)
    {
        for (int rov = 0; rov < outputMatrix.GetLength(0); rov++)
        {
            for (int col = 0; col < outputMatrix.GetLength(1); col++)
            {
                Console.Write(outputMatrix[rov, col]);
            }
            Console.WriteLine();
        }
    }
    

    
}
