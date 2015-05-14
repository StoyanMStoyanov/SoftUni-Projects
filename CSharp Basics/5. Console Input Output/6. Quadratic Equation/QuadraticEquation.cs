using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        float aValue = float.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        float bValue = float.Parse(Console.ReadLine());
        Console.Write("Enter real number: ");
        float cValue = float.Parse(Console.ReadLine());
        double discriminanta = (bValue * bValue) - (4 * aValue * cValue);
        if (discriminanta > 0)
        {
            double x2 = (-bValue + Math.Sqrt(discriminanta)) / (2 * aValue);
            double x1 = (-bValue - Math.Sqrt(discriminanta)) / (2 * aValue);
            Console.WriteLine("X1 = {0}, X2 = {1}.", x1, x2);
        }
        else if (discriminanta == 0)
        {
            double x = -(bValue / (2 * aValue));
            Console.WriteLine("X1 = X2 = {0}.", x);
        }
        else Console.WriteLine("The quadratic equation no real roots.");
    }
}
