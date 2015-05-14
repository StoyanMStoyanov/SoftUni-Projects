using System;

class NewHouse
{
    static void Main()
    {
        Console.Write("Enter height of the house: ");
        int n = int.Parse(Console.ReadLine());
        for (int index = 1; index <= n; index+=2)
        {
            Console.WriteLine("{1}{0}{1}", new string('*', index), new string('-', (n-index)/2));
        }
        for (int index = 0; index < n ; index++)
        {
            Console.WriteLine("|{0}|", new string('*', n-2));
        }
        
    }
}
