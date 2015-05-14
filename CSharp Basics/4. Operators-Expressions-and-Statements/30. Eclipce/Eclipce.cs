using System;

class Eclipce
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sreda = n / 2;

        Console.WriteLine(" {0}{1}{0} ",
            new string('*', (2 * n) - 2), new string(' ', n + 1));
        for (int index = 1; index <= n - 2; index++)
        {
            if (index == sreda)
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', (2 * n) - 2), new string('-', n - 1));
            else 
                Console.WriteLine("*{0}*{1}*{0}*",
                    new string('/', (2 * n) - 2), new string(' ', n - 1));
        }
        Console.WriteLine(" {0}{1}{0} ",
            new string('*', (2 * n) - 2), new string(' ', n + 1));
    }
}
