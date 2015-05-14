using System;

class Boat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = 1;
        int sreda = (n / 2) + 1;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}{1}{2}", new string('.', n - temp ), 
                new string('*', temp), 
                new string('.', n));
            if (i >= sreda) temp -= 2;
            else temp += 2;
        }        
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",new string('.', i), new string('*', (2 * n) - (2 * i)));
        }
        
    }
}
