using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class BiggestTableRow
{
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\17. Biggest Table Row_Тестове\\test.005.in.txt");
        Console.SetIn(file);
#endif
        const string pattern = @"<td>([+-]?\d+\.?\d*)";//<td>([+-]?\d+\.?\d*)
        Regex regex = new Regex(pattern);

        string result = string.Empty;
        double sum = double.MinValue;

        string inputLine = Console.ReadLine();
        while (inputLine != "</table>")
        {
            MatchCollection matches = regex.Matches(inputLine);
            if (matches.Count > 0)
            {
                double currentSum = 0;
                List<string> currentResult = new List<string>();
                foreach (Match item in matches)
                {                    
                    double value = double.Parse(item.Groups[1].ToString());
                    currentSum += value;
                    currentResult.Add(item.Groups[1].ToString());
                }
                if (currentSum > sum)
                {
                    sum = currentSum;
                    result = string.Join(" + ", currentResult);
                }
            }
            inputLine = Console.ReadLine();            
        }
        if (sum == double.MinValue)
        {
            Console.WriteLine("no data");
        }
        else
        {
            Console.WriteLine(sum + " = " + result);
        }
    }
}
