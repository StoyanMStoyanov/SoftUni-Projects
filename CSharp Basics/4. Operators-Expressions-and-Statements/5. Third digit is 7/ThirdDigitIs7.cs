using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter integer value: ");
        int value = int.Parse(Console.ReadLine());
        char temp = value.ToString()[value.ToString().Length - 3];
        Console.WriteLine("Third digit of value {0} is 7: {1}.",value, temp == '7' ? "true" : "false");
    }
}
