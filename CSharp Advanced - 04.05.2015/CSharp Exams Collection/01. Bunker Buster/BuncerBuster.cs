using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class BuncerBuster
{
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\01. Bunker Buster_Нулеви тестове\\test.000.002.in.txt");
        Console.SetIn(file);
#endif

        string inputString = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();
        var arraySize = inputString.Split();
        int rows = int.Parse(arraySize[0]);
        int cols = int.Parse(arraySize[1]);
        
        List<string> inputData = new List<string>();
        int[,] arr = new int[rows, cols];
        while (inputString != "cease fire!")
        {
            inputString = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();
            inputData.Add(inputString);
        }
        foreach (var item in inputData)
        {
            PopulateArray(inputData, arr);           
        }
        PrintArray(arr);
        for (int index = rows; index < inputData.Count-1; index++)
        {
            string bombData = Regex.Replace(inputData[rows], @"\s{2,}", " ").Trim();
            ChangeSellPover(arr, bombData);
        }

        long damageBuncers = CountDamageBuncers(arr);
        Console.WriteLine("Destroyed bunkers: {0}", damageBuncers);
        double damage = (double)damageBuncers/(rows * cols);        
    }

    private static long CountDamageBuncers(int[,] arr)
    {
        long count = 0;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row, col] <= 0) count++;
            }            
        }
        return count;
    }

    private static void ChangeSellPover(int[,] arr, string bombData)
    {
        var bomb = bombData.Split();
        int bombRow = int.Parse(bomb[0].ToString());
        int bombCol = int.Parse(bomb[1].ToString());
        char symbol = bomb[2][0];
               
        int symbolValue = (int)symbol;
        double halfDoubleValue = Math.Round((double)(symbolValue + 0.1) / 2);
        
        int halfSymbolValue = (int)halfDoubleValue;
        
        arr[bombRow, bombCol] -= symbolValue;

        if (isValid(bombRow-1, bombCol-1, arr))
            arr[bombRow-1, bombCol-1] -= halfSymbolValue;
        if (isValid(bombRow - 1, bombCol, arr))
            arr[bombRow-1, bombCol] -= halfSymbolValue;
        if (isValid(bombRow - 1, bombCol + 1, arr))
            arr[bombRow-1, bombCol+1] -= halfSymbolValue;

        if (isValid(bombRow, bombCol - 1, arr))
            arr[bombRow, bombCol - 1] -= halfSymbolValue;
        if (isValid(bombRow, bombCol + 1, arr))
            arr[bombRow, bombCol + 1] -= halfSymbolValue;

        if (isValid(bombRow + 1, bombCol - 1, arr))
            arr[bombRow + 1, bombCol-1] -= halfSymbolValue;
        if (isValid(bombRow + 1, bombCol, arr))
            arr[bombRow + 1, bombCol] -= halfSymbolValue;
        if (isValid(bombRow + 1, bombCol + 1, arr))
            arr[bombRow + 1, bombCol + 1] -= halfSymbolValue;
        
    }

    private static bool isValid(int row, int col, int[,] arr)
    {
        if (row >= 0 && row < arr.GetLength(0) && col >= 0 && col < arr.GetLength(1))
            return true;
        return false;
    }    

    private static void PrintArray(int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write("{0,5}", arr[row, col]);
            }
            Console.WriteLine();
        }
    } 

    private static void PopulateArray(List<string> inputData, int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            var inputStr = inputData[row].Split();
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                arr[row, col] = int.Parse(inputStr[col]);
            }
        }
    }

}
