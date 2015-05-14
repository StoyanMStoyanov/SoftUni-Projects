using System;
using System.Text;

class PetarsGame
{
    static void Main()
    {
        ulong startNumber = ulong.Parse(Console.ReadLine());
        ulong endNumber = ulong.Parse(Console.ReadLine());
        string replace = Console.ReadLine();
        char tempChar;
        decimal sum = 0;
        ulong temp = 0;
        for (ulong index = startNumber; index < endNumber; index++)
        {
            temp = index % 5;
            if (temp == 0) sum += index;
            else sum += temp;        
        }
            
       
        string valueStr = sum.ToString();
        if (sum % 2 == 0)
        {
            tempChar = valueStr[0];
            for (int i = 0; i < valueStr.Length; i++)
            {
                if (valueStr[i] == tempChar) Console.Write(replace);
                else Console.Write(valueStr[i]);
            }
        }
        else
        {
            tempChar = valueStr[valueStr.Length - 1];
            for (int i = 0; i < valueStr.Length; i++)
            {
                if (valueStr[i] == tempChar) Console.Write(replace);
                else Console.Write(valueStr[i]);
            }
        }
        Console.WriteLine();
        
    }
}
