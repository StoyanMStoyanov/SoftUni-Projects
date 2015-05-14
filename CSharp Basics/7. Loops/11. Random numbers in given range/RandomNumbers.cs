using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("Enter integer number for N: ");
        int nNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for min range: ");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for max range: ");
        int maxValue = int.Parse(Console.ReadLine());
        Random rand = new Random();
        //Random integer numbers
        Console.Write("Random integer numbers are: ");
        for (int index = 1; index <=nNumber; index++)
        {
            int randInt = rand.Next(minValue, maxValue);
            if (index == nNumber) Console.Write(randInt + ".");
            else Console.Write(randInt + ", ");
        }
        //Random real numbers
        Console.Write("Random double numbers are: ");
        for (int index = 1; index <= nNumber; index++)
        {
            double randDouble = rand.NextDouble() * minValue;
            if (index == nNumber) Console.Write(randDouble + ".");
            else Console.Write(randDouble + ", ");
        }
        Console.WriteLine();
    }
}
