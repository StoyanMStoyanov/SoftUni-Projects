using System;
using System.Text;
using System.Collections.Generic;

class ArrayMatcher
{
    static void Main()
    {
        var input = Console.ReadLine().Split('\\');
        List<char> outputArray = new List<char>();
        string rightStr;
        string leftStr; 
        if (input[2] == "join" || input[2] == "right exclude")
        {
            rightStr = input[0];
            leftStr = input[1];
        }
        else
        {
            rightStr = input[1];
            leftStr = input[0];
        }

        if (input[2] == "join")
        {
            for (int i = 0; i < rightStr.Length; i++)
            {
                char tempChar = rightStr[i];
                for (int j = 0; j < leftStr.Length; j++)
                {
                    if (tempChar == leftStr[j]) outputArray.Add(tempChar);
                }
            }
        }
        else
        {
            
            for (int i = 0; i < rightStr.Length; i++)
            {
                bool isPresent = true;
                char tempChar = rightStr[i];
                for (int j = 0; j < leftStr.Length; j++)
                {
                    if (tempChar == leftStr[j])
                    {
                        isPresent = false;
                        break;
                    }                
                }
                if (isPresent) outputArray.Add(tempChar);
            }
        }
        outputArray.Sort();
        foreach (var item in outputArray)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
