using System;

class SumNumbers
{
    static void Main()
    {
        int numbers = 0;
        double sumNumbers = 0;
        do
        {
            Console.Clear();
            Console.Write("Enter positive integer value: ");
        }while (!int.TryParse(Console.ReadLine(), out numbers));
        float value = 0;
        for (int i = 0; i < numbers; i++)
        {
            Console.Write("Enter real number {0}: ", i);
            while (!float.TryParse(Console.ReadLine(), out value)) ;
            sumNumbers += value;
        }
        Console.WriteLine("The sum of all numbers is: {0,6:f4}.", sumNumbers);
    }
}
