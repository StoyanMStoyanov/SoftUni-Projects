using System;

using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        String text = "Here is the link:<br>" +
 "[URL=http://www.devbg.org]БАРС[/URL]<br>\n" +
 "and the logo:[URL=http://www.devbg.org][IMG]\n" +
 "http://www.devbg.org/basd-logo.png[/IMG][/URL]\n";
        string pattern = @"\[URL=(?<url>[^\]]+)\](?<content>(.|\s)*?)\[/URL\]";
        string newPatt = "<a href=\"${url}\">${content}</a>";
        string newText =
        Regex.Replace(text, pattern, newPatt);
        Console.WriteLine(newText);
    }
}
