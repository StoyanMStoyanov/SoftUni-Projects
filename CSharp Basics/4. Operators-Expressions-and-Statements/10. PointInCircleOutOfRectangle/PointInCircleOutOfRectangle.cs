using System;

class PointInCircleOutOfRectangle
{
    static void Main()
    {
        double xCenter = 1;
        double yCenter = 1;
        double radius = 1.5;
        Console.Write("Enter real value for x: ");
        double xCoord = double.Parse(Console.ReadLine());
        Console.Write("Enter real value for y: ");
        double yCoord = double.Parse(Console.ReadLine());
        bool inCircle = Math.Pow(xCoord - xCenter, 2) + Math.Pow(yCoord - yCenter, 2) <= (radius * radius) ? true : false ;
        bool outOfRectangle = yCoord > 1 ? true : false;
        Console.WriteLine("The point is in circle and out of rectangle is: {0}.", inCircle && outOfRectangle ? "Yes" : "No");
    }
}
