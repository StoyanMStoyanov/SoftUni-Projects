using System;
using System.Collections.Generic;

class LargerThanNeighbors
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
    }

    private static string IsLargerThanNeighbours(int[] numbers, int i)
    {
        bool temp;
        if (i == 0) temp = i > numbers[i + 1];
        else if (i == numbers.Length - 1) temp = i > numbers[i - 1];
        else temp = numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1];

        return temp.ToString();
    }
}
