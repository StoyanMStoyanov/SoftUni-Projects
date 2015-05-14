using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string letters = "aaaaabbbbbcdddeeeedssaa";
        string pattern = @"([a-z]+)\1";
        StringBuilder sb = new StringBuilder();

        Regex regex = new Regex(pattern);
        MatchCollection match = regex.Matches(letters);
        string result = regex.Replace(letters, "*");
        Console.WriteLine(result);
        Console.WriteLine(new string('-', 50));
        foreach (var item in match)
        {
            Console.WriteLine(item);
            sb.Append(item.ToString()[0]);
        }
        Console.WriteLine(new string('-', 50));
        Console.WriteLine(sb);

    }
}
