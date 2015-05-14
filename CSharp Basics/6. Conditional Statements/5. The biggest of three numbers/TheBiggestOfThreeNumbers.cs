using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        double biggestValue = double.MinValue;
        for (int index = 0; index < 3; index++)
        {            
            Console.Write("Enter value: ");
            double tempValue = double.Parse(Console.ReadLine());
            if (tempValue > biggestValue) biggestValue = tempValue;
        }
        Console.WriteLine("The biggest value is: {0}.", biggestValue);
    }
}
