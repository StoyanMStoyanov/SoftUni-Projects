using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] inputStr = Console.ReadLine().Split(new string[]{" "}, 
            StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> strDictionary = new Dictionary<string, int>();
        for (int index = 0; index < inputStr.Length; index++)
        {
            if (strDictionary.ContainsKey(inputStr[index]))            
                strDictionary[inputStr[index]]++;            
            else
                strDictionary.Add(inputStr[index], 1);
        }
        foreach (var item in strDictionary)
        {
            for (int i = 0; i < item.Value; i++)
            {
                Console.Write(item.Key + " ");
            }
            Console.WriteLine();
        }
    }
}
