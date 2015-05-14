using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main()
    {

        int value = int.Parse(Console.ReadLine());
        string[] inputStr = Console.ReadLine().Split(new string[] { " " },
            StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[inputStr.Length];
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = int.Parse(inputStr[i]);
        List<string> combinations = new List<string>();
        int allSums = (int)Math.Pow(2, numbers.Length);
        for (int i = 1; i < allSums; i++)
        {
            List<int> subset = new List<int>();
            int sum = 0;
            string binary = Convert.ToString(i, 2).PadLeft(32, '0');

            for (int j = 0; j < binary.Length; j++)
            {
                if (binary[j] == '1')
                {
                    sum += numbers[31 - j];
                    subset.Add(numbers[31 - j]);
                }
            }
            subset.Reverse();            
            if (sum == value) combinations.Add(string.Join(", ", subset));
        }
        SortCombinations(combinations);
    }

    private static void SortCombinations(List<string> combinations)
    {
        Dictionary<int, List<string>> sortedItems = new Dictionary<int, List<string>>();
        foreach (var element in combinations)
        {
            if (sortedItems.ContainsKey(element.Length))
                sortedItems[element.Length].Add(element);
            else
            {
                sortedItems.Add(element.Length, new List<string>());
                sortedItems[element.Length].Add(element);
            }
        }

        foreach (var item in sortedItems)
        {
            var itemKey = sortedItems[item.Key];
            //var bbb = SortRow(aaa); //Da porabotia po sortirane na redovete
            foreach (var element in itemKey)            
                Console.WriteLine(element);
       }
    }

    static List<string> SortRow(List<string> nums)
    {
        List<int[]> tempKeyNums = new List<int[]>();
        List<string> returned = new List<string>();
        for (int i = 0; i < nums.Count; i++)
        {            
            int[] tempNums = new int[nums[i].Length];
            var strTemp = nums[i].Split(' ');
            for (int j = 0; j < strTemp.Length; j++)
            {
                tempNums[j] = int.Parse(strTemp[j]);
                tempKeyNums.Add(tempNums);
            }            
        }
        SortedSet<int> firstValues = new SortedSet<int>();
        foreach (var item in tempKeyNums)
            firstValues.Add(item[0]);
        foreach (var item in firstValues)
        {
            foreach (var element in tempKeyNums)
            {
                if (element[0] == item) returned.Add(string.Join(" ", element));
            }
        }
        return returned;
    }

}
