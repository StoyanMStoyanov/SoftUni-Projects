using System;

class NumberNotDivisible3And7
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        for (int index = 1; index <= number; index++)
        {
            if (index % 3 == 0 || index % 7 == 0) continue;
            Console.Write(index + " ");
        }
        Console.WriteLine();
    }
}
