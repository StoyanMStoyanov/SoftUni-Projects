using System;

class Headphones
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*{1}*{0}",
            new string('-', n / 2),
            new string('*', n));
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{0}",
            new string('-', n / 2),
            new string('-', n));
        }
        int temp = 3;
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("{0}{1}{0}-{0}{1}{0}",
            new string('-', (n - temp) / 2),
            new string('*', temp));
            if (i < n / 2) temp += 2;
            else temp -= 2;
        }
    }
}
