using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

class TheNumbers
{
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\15. The Numbers_Тестове\\test.000.001.in.txt");
        Console.SetIn(file);
#endif
        const string pattern = @"\d+";

        string inputMessage = Console.ReadLine();
        MatchCollection messageData = Regex.Matches(inputMessage, pattern);
        StringBuilder result = new StringBuilder();
        for (int element = 0; element < messageData.Count; element++ )
        {
            int currentValue = int.Parse(messageData[element].ToString());
            result.AppendFormat("0x{0}", currentValue.ToString("X").PadLeft(4, '0'));
            if (element < messageData.Count - 1)
            {
                result.Append("-");
            }
            
        }
        Console.WriteLine(result);
    }
}
