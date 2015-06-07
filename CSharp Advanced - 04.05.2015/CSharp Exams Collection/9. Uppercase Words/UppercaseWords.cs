using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

class UppercaseWords
{
    static void Main()
    {
        
        Regex regex = new Regex(@"(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])");
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "end" | line == "END" | line == "End") break;
            MatchCollection match = regex.Matches(line);
            for (int i = match.Count - 1; i >= 0; i--)
            {
                string word = StrRev(match[i].ToString());

                if (match[i].ToString().CompareTo(word) == 0) 
                    word = DoubleChars(match[i].ToString());
                line = line.Remove(match[i].Index, match[i].Length);
                line = line.Insert(match[i].Index, word.ToString());
                
            }
            //PrintResult(line);
            Console.WriteLine(SecurityElement.Escape(line));
            //Console.WriteLine(new string('-', 30));
        }
    }

    private static string StrRev(string p)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in p)
        {
            sb.Insert(0, item);
        }
        return sb.ToString();
    }

    private static string DoubleChars(string matchWord)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in matchWord)
            sb.Append(new string(item, 2));
        return sb.ToString();
    }

    private static void PrintResult(MatchCollection regex)
    {

        foreach (var item in regex)
        {
            Console.WriteLine(item);
        }
    }
}
