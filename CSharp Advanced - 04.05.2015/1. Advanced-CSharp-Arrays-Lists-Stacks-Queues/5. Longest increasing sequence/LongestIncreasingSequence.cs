using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LongestIncreasingSequence
{
    static void Main()
    {
        string[] inputStr = Console.ReadLine().Split(new string[] { " "}, 
            StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[inputStr.Length];
        for (int index = 0; index < inputStr.Length; index++)
            numbers[index] = int.Parse(inputStr[index]);
        int startIndex = 0;
        int tempStartIndex = 0;
        int endIndex = 0;
        int tempEndIndex = 0;
        
        for (int j = 1; j < numbers.Length; j++)
        {
            if (numbers[j - 1] < numbers[j])
            {
                tempEndIndex++;
                if (tempEndIndex == numbers.Length - 1 
                    && (tempEndIndex - tempStartIndex < endIndex - startIndex))
                    PrintNumbers(tempStartIndex, tempEndIndex, numbers);
                continue;
            }
            else
            {
                if (tempEndIndex - tempStartIndex > endIndex - startIndex)
                {
                    startIndex = tempStartIndex;
                    endIndex = tempEndIndex;
                }
                PrintNumbers(tempStartIndex, tempEndIndex, numbers);
                tempStartIndex = j;
                tempEndIndex = j;
            }
        }
        if (tempEndIndex - tempStartIndex > endIndex - startIndex)
        {
            startIndex = tempStartIndex;
            endIndex = tempEndIndex;
            PrintNumbers(tempStartIndex, tempEndIndex, numbers);
        }
        
        Console.Write("Longest: ");
        PrintNumbers(startIndex, endIndex, numbers);
        //Console.WriteLine(startIndex + " " + endIndex);
    }
    static void PrintNumbers(int start, int end, int[] number)
    {
        for (int i = start; i <= end; i++)
            Console.Write(number[i] + " ");
        Console.WriteLine();
    }
}
