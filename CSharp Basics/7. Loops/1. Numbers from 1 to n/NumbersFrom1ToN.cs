using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        for (int index = 1; index <= number; index++)
        {
            Console.Write(index + " ");
        }
        Console.WriteLine();
    }
}
