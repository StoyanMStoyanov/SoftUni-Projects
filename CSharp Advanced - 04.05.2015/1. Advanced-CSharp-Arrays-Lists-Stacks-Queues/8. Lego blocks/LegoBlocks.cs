using System;
using System.Collections.Generic;
using System.Linq;

class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> arraysRows = new List<string>();
        for (int i = 0; i < 2 * n; i++)
            arraysRows.Add(Console.ReadLine());
        bool isEqual = false;
        int line = CountDigit(arraysRows[0]) + CountDigit(arraysRows[n]);
        for (int i = 1; i < n; i++)
        {
            int rowCount = CountDigit(arraysRows[i]) + CountDigit(arraysRows[i + n]);
            if (rowCount != line)
            {
                isEqual = true;
                break;
            }
        }
        if (isEqual)
        {
            int cellsCount = 0;
            foreach (var item in arraysRows)
                cellsCount += CountDigit(item);
            Console.WriteLine("The total number of cells is: {0}", cellsCount);
        }
        else
        {
            for (int i = 0; i < n; i++)            
                Console.WriteLine(ConcatTwoStrings("[" + arraysRows[i], arraysRows[i + n]) + "]");            
        }        
    }

    static int CountDigit(string digits)
    {
        int temp = digits.Split(new string[]{" "}, 
            StringSplitOptions.RemoveEmptyEntries).Length;
        return temp;
    }
    static string ConcatTwoStrings(string firstStr, string secondStr)
    {
        var first = firstStr.Split(new string[]{" "}, 
            StringSplitOptions.RemoveEmptyEntries);
        var second = secondStr.Split(new string[]{" "}, 
            StringSplitOptions.RemoveEmptyEntries);

        List<string> charStr = new List<string>();
        foreach (var item in second)
            charStr.Insert(0, item);

        return string.Join(", ", first) + ", " + string.Join(", ", second.Reverse());
    }
}
