using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class TextTransformer
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "burp") break;
            sb.Append(line);
        }
        Regex regex = new Regex(@"\s{2,}");
        string input = regex.Replace(sb.ToString(), " ");
        //Console.WriteLine(input);
        string wordPattern = @"(?<=\$)([\w\S]+)(?=\$)|(?<=\%)([\w\S]+)(?=\%)|(?<=\&)([\w\S]+)(?=\&)|(?<=\')([\w\S]+)(?=\')";
        Regex words = new Regex(wordPattern);
        MatchCollection matches = words.Matches(sb.ToString());
        StringBuilder groups = new StringBuilder();
        StringBuilder result = new StringBuilder();
        for (int i = 1; i < 4; i++)
        {
            foreach (Match item in matches)
            {
                if(isValid(item.Groups[i]))
                    groups.Append(item.Groups[i]);
            }
            
            result.Append(ConvertGroup(groups.ToString(), i) + " ");
            //Console.WriteLine(result);
            groups.Clear();
        }
        Console.WriteLine(result);
    }

    private static bool isValid(Group group)
    {
        string temp = group.Value;
        if(temp.IndexOf('$') >= 0) return false;
        if(temp.IndexOf('%') >= 0) return false;
        if(temp.IndexOf('&') >= 0 ) return false;
        if(temp.IndexOf('\'') >= 0 ) return false;
        return true;
    }

    private static string ConvertGroup(string p, int i)
    {
        StringBuilder sb = new StringBuilder(p.Length);
        int w =0;
        for (int j = 0; j < p.Length; j++)
        {
            if(j %2 ==0) 
                w = (int)p[j] + i;
            else w = (int)p[j] - i;
            sb.Append((char)w);
        }
        return sb.ToString();
    }
}
