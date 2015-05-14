using System;

class Sunlight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', (3 * n) / 2));

        for (int index = 1; index < n; index++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", 
                new string('.', index),
                new string('.', ((3 * n) / 2) - index - 1));
        }
        for (int index = 1; index <= n / 2; index++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', n),
                new string('*', n));
        }
        Console.WriteLine("{0}", new string('*', 3 * n));
        for (int index = 1; index <= n / 2; index++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('.', n),
                new string('*', n));
        }
        for (int index = n - 1; index > 0; index--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
                new string('.', index),
                new string('.', ((3 * n) / 2) - index - 1));
        }
        Console.WriteLine("{0}*{0}", new string('.', (3 * n) / 2));
    }
}
