using System;

class MinMaxSumAvrgOfNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double maxNumber = double.MinValue;
        double minNumber = double.MaxValue;
        double sum = 0;
        double tempNumber = 0;
        for (int index = 1; index <= number; index++)
        {
            Console.Write("Enter number: ");
            tempNumber = double.Parse(Console.ReadLine());
            if (tempNumber >= maxNumber) maxNumber = tempNumber;
            if (tempNumber < minNumber) minNumber = tempNumber;
            sum += tempNumber;
        }
        Console.WriteLine("\nMin = {0}\nMax = {1}\nSum = {2}\nAvrg = {3}", minNumber, maxNumber, sum, sum / number);
    }
}
