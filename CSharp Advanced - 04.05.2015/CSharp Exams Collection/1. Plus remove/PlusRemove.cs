using System;
using System.Collections.Generic;

class PlusRemove
{
    static void Main()
    {
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
        char[,] chArray = new char[count, maxLength];
        for (int i = 0; i < chArray.GetLength(0); i++)
        {
            string temp = inputMatrix[i];
            for (int j = 0; j < temp.Length; j++)            
               chArray[i,j] = temp[j];            
        }
        char[,] chTempArray = new char[count, maxLength];
        char empty = char.MinValue;
        for (int i = 0; i < chArray.GetLength(0)-2; i++)
        {
            for (int j = 1; j < chArray.GetLength(1)-1; j++)
            {
                char tempChar = CharToLover(chArray[i, j]);
                if (CharToLover( chArray[i, j]) == tempChar &
                    CharToLover(chArray[i + 1, j - 1]) == tempChar &
                    CharToLover( chArray[i + 1, j]) == tempChar &
                    CharToLover( chArray[i + 1, j + 1]) == tempChar &
                    CharToLover( chArray[i + 2, j]) == tempChar)
                {
                    chTempArray[i, j] = tempChar;
                    chTempArray[i + 1, j - 1] = tempChar;
                    chTempArray[i + 1, j] = tempChar;
                    chTempArray[i + 1, j + 1] = tempChar;
                    chTempArray[i + 2, j] = tempChar;
                }
               
            }
        }

        for (int i = 0; i < chArray.GetLength(0); i++)
        {
            for (int j = 0; j < chArray.GetLength(1); j++)
            {
                if (chTempArray[i, j] == empty) Console.Write(chArray[i,j]);
            }
            Console.WriteLine();
        }
    }

    private static char CharToLover(char inputChar)
    {
        string temp = inputChar.ToString().ToLower();
        return temp[0];
    }
}
