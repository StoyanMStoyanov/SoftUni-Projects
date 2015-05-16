using System;

class TextFilter
{
    static void Main()
    {
        string[] separators = { ", " };
        string[] bannedWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);//{"Linux", "Windows"};
        string text = Console.ReadLine();
        for (int i = 0; i < bannedWords.Length; i++)        
            text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
        Console.WriteLine(text);
    }
}
