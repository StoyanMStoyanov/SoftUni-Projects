using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TempProject
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] inputStr = Console.ReadLine().Split(' ');
        bool isStuck = true;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    for (int m = 0; m < n; m++)
                    {
                        //if (i == j || j == k || k == m) continue;
                        string a = inputStr[i];
                        string b = inputStr[j];
                        string c = inputStr[k];
                        string d = inputStr[m];
                        if (a != b && a != c && a != d && b != c && b != d && c != d)
                        {
                            string first = a + b;
                            string second = c + d;
                            if (first.Equals(second))
                                Console.WriteLine(a + "|" + b + "==" + c + "|" + d);
                            isStuck = false;
                        }
                    }
        if (isStuck) Console.WriteLine("No");
    }
}
