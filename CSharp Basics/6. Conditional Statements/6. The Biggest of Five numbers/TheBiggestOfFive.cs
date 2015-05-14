using System;

class TheBiggestOfFive
{
    static void Main()
    {
        Console.Write("Enter value: ");
        double firstValue = double.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        double secondValue = double.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        double thirdValue = double.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        double forthValue = double.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        double fifthValue = double.Parse(Console.ReadLine());

        if (firstValue < secondValue) firstValue = secondValue;
        if (firstValue < thirdValue) firstValue = thirdValue;
        if (firstValue < forthValue) firstValue = forthValue;
        if (firstValue < fifthValue) firstValue = fifthValue;

        Console.WriteLine("The biggest of five values is: {0}.", firstValue);
    }
}
