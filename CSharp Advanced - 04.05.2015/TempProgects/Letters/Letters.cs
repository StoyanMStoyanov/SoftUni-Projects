using System;
using System.Text.RegularExpressions;

class Letters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        string pattern = @"(?<letters>[a-zA-Z0-9])\""letters""";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        foreach (var item in matches)
            Console.Write(item);
        Console.WriteLine();
    }
}
