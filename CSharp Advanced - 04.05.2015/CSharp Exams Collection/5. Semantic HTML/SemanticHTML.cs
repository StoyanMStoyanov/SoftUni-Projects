using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class SemanticHTML
{
    static void Main()
    {
        List<string> outputHTML = new List<string>();
        string line = Console.ReadLine();
        string divPattern = @"div.+";
        Regex divRegex = new Regex(divPattern);
        while (true)
        {
            if (line == "END" | line == "End" | line == "end") break;
            if (divRegex.IsMatch(line))
            {
                var matchName = Regex.Match(line, @"\s+id\s*=\s*""(?<name>\w+)""\s*(?!\w)|\s+class\s*=\s*""(?<name>\w+)""\s*(?!\w)|\s*?<!--\s*(?<name>\w+)\s*-->");
                line = line.Remove(matchName.Index, matchName.Length);
                line = line.Replace("div", matchName.Groups["name"].Value.ToString());
                //line = WhiteSpaces(line);
                outputHTML.Add(line);                
            }
            else
            {
                outputHTML.Add(line);                
            }
            line = Console.ReadLine();
        }
        foreach (var item in outputHTML)
        {
            Console.WriteLine(item);
        }

    }

    private static string WhiteSpaces(string line)
    {
        string pattern = @"(\s{2,})=(\s{2,})";
        Regex regex = new Regex(pattern);
        string result = regex.Replace(line, " ");
        return result;
    }
}
