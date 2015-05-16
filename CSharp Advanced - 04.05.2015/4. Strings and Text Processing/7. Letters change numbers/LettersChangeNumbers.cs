using System;

class LettersChangeNumbers
{
    static void Main()
    {
        string str = Console.ReadLine();
        string[] spaces = { " " };
        string[] inputStr = str.Split(spaces, StringSplitOptions.RemoveEmptyEntries);
        decimal sum = 0;
        for (int i = 0; i < inputStr.Length; i++)
        {
            decimal tempvalue = 0;
            decimal value = decimal.Parse(inputStr[i].Substring(1, inputStr[i].Length - 2));
            if (char.IsLower(inputStr[i][0])) tempvalue += (value * LetterPosition(inputStr[i][0]));
            else tempvalue = value / LetterPosition(inputStr[i][0]);

            if (char.IsLower(inputStr[i][inputStr[i].Length - 1])) 
                tempvalue += LetterPosition(inputStr[i][inputStr[i].Length - 1]);
            else tempvalue -= LetterPosition(inputStr[i][inputStr[i].Length - 1]);
            sum += tempvalue;
        }

        Console.WriteLine("{0:f2}", sum);
    }

    private static int LetterPosition(char p)
    {
        int temp = 0;
        if ((int)p >= 97) temp = (int)p - 96;
        else temp = (int)p - 64;
        return temp;
    }
    
}
