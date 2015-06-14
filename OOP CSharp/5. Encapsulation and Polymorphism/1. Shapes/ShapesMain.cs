using System;
using System.Collections.Generic;

class ShapesMain
{
    static void Main()
    {
        List<IShape> figures = new List<IShape>{
                                   new Triangle(5, 10),
                                   new Triangle(8, 20),
                                   new Rectangle(5, 10),
                                   new Rectangle(8, 20),
                                   new Circle(7),
                                   new Circle(4.35)
                               };

        foreach (var figure in figures)
        {
            Console.WriteLine("{0} - Perimeter: {1:f2}, Area: {2:f2}.", 
                figure.GetType().Name, 
                figure.CalculateArea(), 
                figure.CalculatePerimeter());
        }
    }
}
