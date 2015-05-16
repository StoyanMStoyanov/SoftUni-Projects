using System;
using System.Text.RegularExpressions;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string letters = "aaaaabbbbbcdddeeeedssaa";
        string pattern = @"(\w)\1*";
        StringBuilder sb = new StringBuilder();

        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(letters);        
        
        foreach (var item in matches)
        {
            //Console.WriteLine(item);
            Console.Write(item.ToString()[0]);
        }
        Console.WriteLine();
    }
}
