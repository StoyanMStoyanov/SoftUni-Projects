using System;
using System.Text;

class SpyHard
{
    static void Main()
    {
        int numeralSystem = int.Parse(Console.ReadLine());
        string message = Console.ReadLine().ToLower();

        Console.Write("{0}{1}", numeralSystem, message.Length);
        int charSum = 0;

        foreach (var item in message)
        {
            if (item >= 'a' & item <= 'z')            
                charSum += (int)item - 96;            
            else 
                charSum += (int)item;
        }
        StringBuilder sb = new StringBuilder();
        while (charSum > 0)
        {
            sb.Insert(0, charSum % numeralSystem);
            charSum /= numeralSystem;
        }
        Console.WriteLine(sb);
    }
}
