using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class HTMLFromTeleric
{
    static void Main(string[] args)
    {
        StringBuilder tag = new StringBuilder();
        while (true)
        {
            string temp = Console.ReadLine();
            if (temp == "END") break;
            tag.Append(temp);
        }
        string pattern = @"<a\b[^>]*>(.*?)</a>"; //pattern without subpatterns       
        MatchCollection collection = Regex.Matches(tag.ToString(), pattern);


        //string regex = @"<\s*a\s[^>]*\bhref\b\s*=\s*('(?<hyperlink>[^']*)'|""(?<hyperlink>[^""]*)""|(?<hyperlink>\s*))[^>](?<hyperlinktext>(.|\s)*?)<\s*/a\s*>";
        string regex = @"<\s*a\s[^>]*\bhref\b\s*=\s*('(?<hyperlink>[^']*)'|""(?<hyperlink>[^""]*)""|(?<hyperlink>\/\w+)|\s*(?<hyperlink>[\w\W]+)\s+?)";
        Regex href = new Regex(regex);

        foreach (var item in collection)
        {
            string tempStr = Regex.Match(item.ToString(), regex).Groups["hyperlink"].Value;
            if (tempStr == string.Empty) continue;
            Console.WriteLine(tempStr);
        }
        

    }
}
