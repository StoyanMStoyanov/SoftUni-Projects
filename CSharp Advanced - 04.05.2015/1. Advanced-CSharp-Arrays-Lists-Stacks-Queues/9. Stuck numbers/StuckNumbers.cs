using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputStr = Console.ReadLine().Split(' ');
        bool isStuck = true;
        List<string> temp = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string a = inputStr[i];
            for (int j = 0; j < n; j++)
            {
                if (j == i) continue; 
                string b = inputStr[j];
                for (int k = 0; k < n; k++)
                {                    
                    if (k == i || k == j) continue;
                    temp.Add(inputStr[k]);                    
                }
                string[] cd = CheckNumbers(a+b, string.Join(" ", temp)).Split(' ');
                if (cd.Length != 1)
                {
                    Console.WriteLine("{0}|{1}=={2}|{3}", a, b, cd[0], cd[1]);
                    isStuck = false;
                }
                temp.Clear();
            }
            
        }
        if (isStuck) Console.WriteLine("No");
    }
   
    static string CheckNumbers(string ab, string input)
    {
        string[] others = input.Split(' ');
        StringBuilder cd = new StringBuilder();
        for (int i = 0; i < others.Length; i++)
        {
            string c = others[i];
            for (int j = 0; j < others.Length; j++)
            {
                if (i == j) continue;
                string d = others[j];
                if (ab == (c + d)) cd.Append(c + " " + d);                
            }
        }
        return cd.ToString();
    }
}
