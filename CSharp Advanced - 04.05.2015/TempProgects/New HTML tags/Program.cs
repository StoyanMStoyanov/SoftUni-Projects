using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StringBuilder tag = new StringBuilder();
        while (true)
        {
            string temp = Console.ReadLine();
            if (temp == "END") break;
            tag.Append(temp);
        }
        string pattern = @"<a\b[^>]*>(.*?)</a>"; //pattern without subpatterns       
        MatchCollection myCollection = Regex.Matches(tag.ToString(), pattern);
        string hrefPattern =    @"<\s*a\s[^>]*\bhref\s*=\s*" +
                                @"('[^']*'|""[^""]*""|\S*)[^>]*>" +
                                @"(.|\s)*?<\s*/a\s*>";
        MatchCollection nakovCollection = Regex.Matches(tag.ToString(), hrefPattern);
        PrintCollection(myCollection);
        Console.WriteLine(new string('-', 50));
        PrintCollection(nakovCollection);
    }

    

    static void PrintCollection(MatchCollection someCollection)
    {
        foreach (var item in someCollection)        
            Console.WriteLine(item);        
    }
}
