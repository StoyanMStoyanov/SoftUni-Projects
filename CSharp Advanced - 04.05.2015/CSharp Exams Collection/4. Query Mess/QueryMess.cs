using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class QueryMess
{
    static void Main()
    {
        string line = string.Empty;
        List<string> inputData = new List<string>();
        Dictionary<string, List<string>> matches = new Dictionary<string, List<string>>();
        string splitPattern = @"[&|?]";
        while (true)
        {
            line = Console.ReadLine();
            if (line == "End" | line == "end" | line == "END") break;
            inputData.Add(line);
        }
        foreach (var item in inputData)
        {
            string tempLine = Regex.Replace(item, @"(\+%20\+|\+%20|%20\+|\+|%20)", " ");
            string[] split = Regex.Split(tempLine, splitPattern, RegexOptions.IgnorePatternWhitespace);

            AppendInDictionary(split, matches);
            PrintDictionary(matches);
            matches.Clear();
        }
    }

    private static void AppendInDictionary(string[] split, Dictionary<string, List<string>> matches)
    {
        foreach (var item in split)
        {
            var keyValue = Regex.Match(item, @"=(.+)");
            var key = Regex.Match(item, @"\w+(?=\=|\s+\=)").ToString();
            string value = keyValue.Groups[1].ToString().Trim();
            if (key == "") continue;
            if (matches.ContainsKey(key))
                matches[key].Add(value);
            else
            {
                matches.Add(key, new List<string>());
                matches[key].Add(value);
            }
        }
    }
    private static void PrintDictionary(Dictionary<string, List<string>> inputData)
    {
        foreach (var item in inputData)
        {
            Console.Write("{0}=[{1}]", item.Key, string.Join(", ", item.Value));
        }
        Console.WriteLine();
    }
}
