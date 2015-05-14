using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PithagorienNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        SortedDictionary<int, long> numbers = new SortedDictionary<int, long>();
        for (int index = 0; index < n; index++)
        {
            int temp = int.Parse(Console.ReadLine());
            numbers.Add(temp, temp * temp);
        }
        int count = 0;
        var keys = numbers.Keys.ToArray();
        for (int i = 0; i < keys.Length - 1; i++)
        {
            for (int k = 0; k < keys.Length; k++)
            {                
                for (int j = 0; j < keys.Length; j++)
                {
                    if (keys[i] <= keys[k])
                    {
                        long sum = numbers[keys[i]] + numbers[keys[k]];
                        if (sum == numbers[keys[j]])
                        {
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}",
                                keys[i], keys[k], keys[j]);
                            count++;
                        }
                    }
                }
            }
        }
        if (count == 0) Console.WriteLine("No");
    }
}
