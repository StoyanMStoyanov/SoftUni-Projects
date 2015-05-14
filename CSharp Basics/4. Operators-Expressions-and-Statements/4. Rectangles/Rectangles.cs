using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter real value for width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter real value for height: ");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("Rectangle's perimeter is: {0}.", (width + height)*2);
        Console.WriteLine("Rectangle's area is: {0}.", width * height);

    }
}
