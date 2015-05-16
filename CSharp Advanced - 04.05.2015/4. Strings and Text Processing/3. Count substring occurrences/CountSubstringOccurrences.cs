using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string inputStr = Console.ReadLine().ToLower();        
        string searchStr = Console.ReadLine().ToLower();
        int index = 0;
        int count = 0;
        while (index<=inputStr.Length-1)
        {
            if (inputStr.IndexOf(searchStr, index) == -1) break;
            if (inputStr.IndexOf(searchStr, index) >= index)
            {
                count++;
                index = inputStr.IndexOf(searchStr, index) + 1;
            }
        }
        Console.WriteLine(count);
    }
}
