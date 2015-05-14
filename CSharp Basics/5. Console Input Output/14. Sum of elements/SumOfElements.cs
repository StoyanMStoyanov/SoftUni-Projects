using System;
using System.Collections.Generic;

class SumOfElements
{
    static void Main()
    {
        Console.Write("Write some numbers separated with space: ");
        string numbers = Console.ReadLine();
        string[] str = numbers.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> intArry = new List<int>();
        foreach (var item in str)        
            intArry.Add(int.Parse(item));
        
        intArry.Sort();
        int sum = 0;
        bool equals = false;
        int biggestValue = intArry[intArry.Count-1];
        for (int index = 0; index < intArry.Count-1; index++)        
			 sum += intArry[index];
        
        if (biggestValue == sum) equals = true;

        if (equals)
            Console.WriteLine("Yes,  sum = {0}", sum);
        else
            Console.WriteLine("No, diff = {0}", sum - biggestValue >= 0 ? sum - biggestValue : biggestValue - sum);
    }
}
