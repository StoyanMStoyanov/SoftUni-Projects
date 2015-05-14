using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.Write("Enter integer value: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} - {1}", value, value % 35 == 0 ? "thrue" : "false" );
    }
}
