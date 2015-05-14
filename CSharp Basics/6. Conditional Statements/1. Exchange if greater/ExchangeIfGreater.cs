using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter first value: ");
        double firstValue = double.Parse(Console.ReadLine());
        Console.Write("Enter first value: ");
        double secondValue = double.Parse(Console.ReadLine());
        if (firstValue > secondValue)
        {
            double tempValue = firstValue;
            firstValue = secondValue;
            secondValue = tempValue;
        }
        Console.WriteLine("{0} {1}", firstValue, secondValue);
    }
}
