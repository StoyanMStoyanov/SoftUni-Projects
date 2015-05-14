using System;

class CalculateFactoriel
{
    static void Main()
    {
        Console.Write("Enter integer number for N: ");
        int nNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for X: ");
        int xNumber = int.Parse(Console.ReadLine());

        double sum = 1;
        double tempFactorial = 1;
        for (int index = 1; index <= nNumber; index++)
        {
            tempFactorial *= index;
            sum += tempFactorial /  Math.Pow(xNumber, index);
        }
        Console.WriteLine("The sum is: {0:f5}.", sum);

    }
}
