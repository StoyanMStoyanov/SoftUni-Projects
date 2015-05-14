using System;

class SelectionSort
{
    static void Main()
    {
        string[] separators = {" ", ","};
        var numStr = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numStr.Length];
        for (int i = 0; i < numStr.Length; i++)
            numbers[i] = int.Parse(numStr[i]);        
        int temp = 0;
        for (int index = 0; index < numbers.Length - 1; index++)            
                if (numbers[index] > numbers[index+1])
                {
                    temp = numbers[index];
                    numbers[index] = numbers[index+1];
                    numbers[index+1] = temp;
                }            
        Console.WriteLine(string.Join(" ", numbers));
    }
}
