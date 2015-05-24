using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class WordCount
{
    static void Main()
    {
        StreamReader keyWords = new StreamReader("../../Words.txt");
        StreamReader textReader = new StreamReader("../../text.txt");
        Dictionary<string, int> allWords = new Dictionary<string, int>();
        string line = "";
        using (textReader)
        {
            line = textReader.ReadLine();
            while (line != null)
            {
                string[] matches = Regex.Split(line, @"\s+");
                foreach (var item in matches)
                {
                    string wordOrLetter = ReturnWordOrChar(item);
                    if (allWords.ContainsKey(wordOrLetter.ToLower()))
                    {
                        allWords[wordOrLetter.ToLower()]++;
                    }
                    else
                    {
                        allWords.Add(wordOrLetter.ToLower(), 1);
                    }
                }
                line = textReader.ReadLine();
            }
        }

        using (keyWords)
        {
            line = keyWords.ReadLine();
            while (line != null)
            {
                string wordOrLetter = ReturnWordOrChar(Regex.Match(line, @"\w+").ToString());
                Console.WriteLine("{0} - {1}", wordOrLetter, allWords[wordOrLetter]);
                line = keyWords.ReadLine();
            }
        }
    }

    private static string ReturnWordOrChar(string input)
    {
        var temp = Regex.Match(input, @"\w+");

        return temp.ToString();
    }
}
