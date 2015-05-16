using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text ="This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";
        string word = "is";
        
        string[] sentences = Regex.Split(text, @"(\s?[.!?])\s?");
        //Regex regex = new Regex(sentence);
        foreach (var item in sentences)
            if (Regex.IsMatch(item, word))
            {
                Console.WriteLine(item);
            }
            
	
    }
}
