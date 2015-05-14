using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        float number1 = float.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        float number2 = float.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        float number3 = float.Parse(Console.ReadLine());
        Console.WriteLine("The sum of numbers {0:F4} + {1:F4} + {2:F4} = {3:F4}.", 
            number1, number2, number3, number1 + number2 + number3);
    }
}
