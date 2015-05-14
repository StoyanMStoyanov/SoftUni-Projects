using System;

class Dumbbell
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sreda = n / 2;
        int index = 1;
        Console.WriteLine("{0}{1}{2}{1}{0}", 
            new string('.', n / 2),
            new string('&', n - (n / 2)),
            new string('.', n));

        for (int i = 1; i < n - 1; i++)
        {
            Console.WriteLine("{0}&{1}&{2}&{1}&{0}",
                new string('.', (n / 2) - index),
                new string('*', (n / 2) + index - 1),
                i == sreda ? new string('=', n) : new string('.', n));
            if (i < sreda) index++;
            else index--;
        }
        Console.WriteLine("{0}{1}{2}{1}{0}",
            new string('.', n / 2),
            new string('&', n - (n / 2)),
            new string('.', n));
    }
}
