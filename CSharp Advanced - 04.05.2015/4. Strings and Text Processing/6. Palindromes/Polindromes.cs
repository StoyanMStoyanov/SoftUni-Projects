using System;
using System.Collections.Generic;

class Polindromes
{
    static void Main()
    {
        string str = "Hi,exe? ABBA! Hog fully a string. Bob";
        string[] spaces = {" ", ",", ".", "?", "!"};
        string[] inputStr = str.Split(spaces, StringSplitOptions.RemoveEmptyEntries);
        List<string> polindromes = new List<string>();
        for (int i = 0; i < inputStr.Length; i++)        
           if (CheckPolindromes(inputStr[i])) polindromes.Add(inputStr[i]);
        polindromes.Sort();
        Console.WriteLine(string.Join(", ", polindromes));
    }

    private static bool CheckPolindromes(string p)
    {
        bool isPolindrome = false;
        int sreda = p.Length / 2;
        if (p.Length == 1) isPolindrome = true;
        else
        {
            for (int i = 0; i < sreda; i++)
            {
                if (p[i].CompareTo(p[p.Length - 1 - i]) != 0) break;
                isPolindrome = true;
            }
        }
        return isPolindrome;
    }
}
