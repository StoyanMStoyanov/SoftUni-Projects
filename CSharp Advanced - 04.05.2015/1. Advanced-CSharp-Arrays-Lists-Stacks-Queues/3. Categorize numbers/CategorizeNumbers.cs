using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main()
    {
        string[] separators = { " "};
        string[] strNumb = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        decimal[] numbers = new decimal[strNumb.Length];
        for (int index = 0; index < strNumb.Length; index++)
            numbers[index] = decimal.Parse(strNumb[index]);

        List<int> intNumbers = new List<int>();
        List<decimal> decNumber = new List<decimal>();
        foreach (var item in numbers)
        {
            if ((item - Math.Floor(item)) != 0) decNumber.Add(item);
            else intNumbers.Add(Convert.ToInt32(item));            
        }

        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}", 
            string.Join(", ", decNumber), decNumber.Min(), 
            decNumber.Max(), decNumber.Sum(), decNumber.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",
            string.Join(", ", intNumbers),intNumbers.Min(),
            intNumbers.Max(), intNumbers.Sum(), intNumbers.Average());
    }
}
