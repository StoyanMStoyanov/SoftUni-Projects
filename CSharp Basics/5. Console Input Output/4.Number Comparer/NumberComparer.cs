using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater is: {0}", (firstNumber - secondNumber) > 0 ? firstNumber : secondNumber);
    }
}
