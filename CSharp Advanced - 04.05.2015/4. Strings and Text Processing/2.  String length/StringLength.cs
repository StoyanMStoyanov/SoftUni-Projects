using System;

class StringLength
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        if (inputStr.Length >= 20)
        {
            for (int i = 0; i < 20; i++)
                Console.Write(inputStr[i]);
            Console.WriteLine();            
        }
        else Console.WriteLine(inputStr + new string('*', (20 - inputStr.Length)));
    }
}
