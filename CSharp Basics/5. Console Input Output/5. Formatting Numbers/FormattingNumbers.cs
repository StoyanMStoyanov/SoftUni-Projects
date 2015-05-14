using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter real number: ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter real number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("{0,-10:X} | {1,10} | {2,10:F2} | {3,-10:f3}", 
            firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0'), secondNumber, thirdNumber);
    }
}
