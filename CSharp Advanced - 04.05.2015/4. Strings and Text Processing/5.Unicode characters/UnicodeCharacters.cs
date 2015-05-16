using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        
        for (int i = 0; i < inputStr.Length;i++ )
        {
            Console.Write("u\\{0}", Convert.ToString((int)inputStr[i], 16).PadLeft(4, '0'));
        }
        Console.WriteLine();
    }
   
}
