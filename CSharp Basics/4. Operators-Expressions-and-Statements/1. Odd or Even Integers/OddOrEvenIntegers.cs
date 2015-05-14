using System;

namespace _1.Odd_or_Even_Integers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Enter integer value: ");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("The value {0} is {1}.", value, value % 2 == 0 ? "Evan" : "Odd" );
        }
    }
}
