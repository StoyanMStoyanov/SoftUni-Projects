using System;
using System.Collections.Generic;

class CountSumbols
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        SortedDictionary<char, int> chars = new SortedDictionary<char, int>();
        foreach (var element in inputStr)
        {
            if (chars.ContainsKey(element))            
               chars[element]++;            
            else            
               chars.Add(element, 1);
        }
        foreach (var el in chars)        
           Console.WriteLine("{0}: {1} time/s", el.Key, el.Value);        
    }
}
