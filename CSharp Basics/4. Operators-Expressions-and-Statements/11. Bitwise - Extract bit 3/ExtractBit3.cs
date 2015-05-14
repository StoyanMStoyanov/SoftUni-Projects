using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 2;
        int numberAndMask = (number & mask) >> 2;
        Console.WriteLine("The third bit is {0}.", numberAndMask == 0 ? 0 : 1);
    }
}
