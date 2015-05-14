using System;
using System.Collections.Generic;


class SubsetSums
{
    static void Main()
    {
        int value = int.Parse(Console.ReadLine());
        string[] inputStr = Console.ReadLine().Split(new string[] { " " },
            StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[inputStr.Length];
        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = int.Parse(inputStr[i]);

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
            if (sum == value) Console.WriteLine(string.Join(", ", subset));
            
        }
    }
    
}
