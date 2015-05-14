using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortArrayOfNumbers
{
    static void Main()
    {
        string[] separators = {" "};
        string[] numStr = (Console.ReadLine()).Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numStr.Length];
        
        for (int i = 0; i < numStr.Length; i++)
            numbers[i] = int.Parse(numStr[i]);
        int temp = 0;
        for (int index = 0; index < numbers.Length - 1; index++)
            for (int j = 0; j < numbers.Length-1; j++)
                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
        Console.WriteLine(string.Join(" ", numbers));
        
    }
}
