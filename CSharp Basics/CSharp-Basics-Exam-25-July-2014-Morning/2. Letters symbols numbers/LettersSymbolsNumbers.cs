using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inputStr;
        int sumLetters = 0;
        int sumChars = 0;
        int sumDigits = 0;

        for (int i = 0; i < n; i++)
        {
            inputStr = Console.ReadLine().ToLower();
            foreach (var item in inputStr)
            {
                if (item == ' ' || item == '\t' || item == '\r' || item == '\n') continue;
                if ((int)item >= 97 && (int)item <= 122) sumLetters += ((int)item - 96) * 10;
                else if ((int)item >= 48 && (int)item <= 57) sumDigits += ((int)item - 48) * 20;
                else sumChars += 200;
            }
        }
        Console.WriteLine("{0}\n{1}\n{2}", sumLetters, sumDigits, sumChars);
        
    }
}
