using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SumOfAllValues
{
    static void Main()
    {
        const string startEndKeysPattern = @"\A([a-zA-Z_]+).+\d([A-z]+)";
        string inputKeyString = Console.ReadLine();
        string inputTextString = Console.ReadLine();
        double sumOfAllValues = 0;
        Match startEndKeys = Regex.Match(inputKeyString, startEndKeysPattern);
        string startKey = startEndKeys.Groups[1].ToString();
        string endKey = startEndKeys.Groups[2].ToString();
        if (startKey == string.Empty || endKey == string.Empty)
        {
            Console.WriteLine("<p>A key is missing</p>");
        }
        else
        {
            string valuesPattern = startKey + "(\\.?\\d+\\.?\\d*)" + endKey;
            //Console.WriteLine(startKey + "   ->   " + endKey);
            MatchCollection values = Regex.Matches(inputTextString, valuesPattern);
            foreach (Match item in values)
            {
                sumOfAllValues += double.Parse(item.Groups[1].ToString());                
            }
            Console.WriteLine("<p>The total value is: <em>{0}</em></p>",
                sumOfAllValues != 0 ? sumOfAllValues.ToString() : "nothing");
        }
    }
}
