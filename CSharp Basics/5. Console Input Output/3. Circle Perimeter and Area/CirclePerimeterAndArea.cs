using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter circle's radius: ");
        double radius = double.Parse(Console.ReadLine());

        Console.WriteLine("Circle's perimeter is: {0,6:F2}.\nCircle's area is: {1,6:F2}.", 2 * Math.PI * radius, radius * radius * Math.PI);
    }
}
