using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sreda = (n / 2);
        Console.WriteLine("{0}{1}{0}",
            new string('*', 2 * n), 
            new string(' ', n));

        for (int index = 1; index <= n - 2; index++)
        {
            Console.WriteLine("*{0}*{1}*{0}*", 
                new string('/', (2 * n) - 2),
                index == sreda ? new string('|', n) : new string(' ', n));
        }
        Console.WriteLine("{0}{1}{0}", 
            new string('*', 2 * n), 
            new string(' ', n));
    }
}
