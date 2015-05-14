using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = 0;
        int charCount = 64;
        //Console.WriteLine(".{0}.", new string('#', n - 2));

        for (int i = 0; i < n; i++)
        {
            if (i == n / 2)
            {
                Console.WriteLine("{0}{1}{0}", 
                    new string('-', n/2), 
                    (char)NextChar(charCount, out charCount));
                temp++;
                continue;
            }
            Console.WriteLine("{0}{1}{2}{3}{0}", 
                new string('~', temp), 
                //new string('.', 1),
                (char)NextChar(charCount, out charCount),
                new string('#', n-(2*temp)-2),
                (char)NextChar(charCount, out charCount));
            
            if (i < (n / 2) - 1) temp++;
            else temp--;
        }        
    }
    private static int NextChar(int value, out int num)
    {
        if (value > 89) value = 65;
        else value++;
        num = value;
        return value;
    }
}
