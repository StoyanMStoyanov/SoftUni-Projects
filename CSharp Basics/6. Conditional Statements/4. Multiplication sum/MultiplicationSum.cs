using System;

class MultiplicationSum
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        bool isPositive = false;
        bool isZero = false;
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0) isZero = true;
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) isPositive = true;
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) isPositive = true;
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) isPositive = true;
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) isPositive = true;

        if (isZero) Console.WriteLine("0");
        else Console.WriteLine("{0}", isPositive ? "+" : "-");
    }
}
