using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class PhoneNumbers
{
    static void Main()
    {
        const string WordPattern = @"([A-Z][a-zA-z]*)[^a-zA-Z+\d]*(\+?\d[\d()\/.\-\s]*\d)";        

        //string input = "Angel$(*^#029661234!@#Pesho ,.' +3592/9653241;'\":{},.Ivan 0888 123 456 John-=_555.123.4567	Stoian!@#$#@	Gosho )=_*	Steven #$(*&+1-(800)-555-2468";
        string input = Console.ReadLine();
        Regex regex = new Regex(WordPattern);
        Dictionary<string, List<string>> ukazatel = new Dictionary<string, List<string>>();
        while (true)
        {
            if (input == "end" || input == "END") break;
            MatchCollection matches = regex.Matches(input);
            StringBuilder output = new StringBuilder();
            foreach (Match item in matches)
            {
                string parsedNumber = ParseNumber(item.Groups[2].ToString());                
                AddToCollection(item.Groups[1], parsedNumber, ukazatel);
            }
            input = Console.ReadLine();
        }
        if (ukazatel.Count != 0)
        {
            Console.Write("<ol>");
            foreach (var item in ukazatel)
            {
                Console.Write("<li><b>{0}:</b> {1}</li>", item.Key, string.Join(", ", item.Value));
            }
            Console.WriteLine("</ol>");
        }
        else
        {
            Console.WriteLine("<p>No matches!</p>");
        }
    }

    private static void AddToCollection(Group group, string parsedNumber, Dictionary<string, List<string>> ukazatel)
    {
        if (ukazatel.ContainsKey(group.ToString()))
        {
            ukazatel[group.ToString()].Add(parsedNumber);
        }
        else
        {
            ukazatel.Add(group.ToString(), new List<string>());
            ukazatel[group.ToString()].Add(parsedNumber);
        }
    }

    private static string ParseNumber(string number)
    {
        StringBuilder resultNumber = new StringBuilder();
        int otmestvane = 0;
        if (number[0] == '+')
        {
            resultNumber.Append(number[0]);
            otmestvane++;
        }
        for (int index = 0 + otmestvane; index < number.Length; index++)
        {
            if (char.IsDigit(number[index]))
            {
                resultNumber.Append(number[index]);
            }
        }
        return resultNumber.ToString();
    }
}
