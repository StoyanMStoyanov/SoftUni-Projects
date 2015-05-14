using System;


class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter double value for X: ");
        double xCoord = double.Parse(Console.ReadLine());
        Console.Write("Enter double value for Y: ");
        double yCoord = double.Parse(Console.ReadLine());
        Console.WriteLine("The point is in cirkle: {0}.", ((xCoord * xCoord) + (yCoord * yCoord)) <= 4 ? "True" : "False");
    }
}
