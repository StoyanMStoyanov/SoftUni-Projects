using System;

class Trapezoids
{
    static void Main()
    {
        bool parseSuccess = false;
        double doubleValue = 0.0;
        double area = 0.0;        
        do
        {
            Console.Write("Enter double value for side a: ");
            parseSuccess = double.TryParse(Console.ReadLine(), out doubleValue);
            if (doubleValue <= 0) 
            {
                parseSuccess = false;
                Console.WriteLine("Invalid value.");
            }
        } while (!parseSuccess);
        double aSide = doubleValue;
        parseSuccess = false;

        do
        {
            Console.Write("Enter double value for side b: ");
            parseSuccess = double.TryParse(Console.ReadLine(), out doubleValue);
            if (doubleValue <= 0)
            {
                parseSuccess = false;
                Console.WriteLine("Invalid value.");
            }
        } while (!parseSuccess);
        double bSide = doubleValue;
        parseSuccess = false;

        do
        {
            Console.Write("Enter double value for h: ");
            parseSuccess = double.TryParse(Console.ReadLine(), out doubleValue);
            if (doubleValue <= 0)
            {
                parseSuccess = false;
                Console.WriteLine("Invalid value.");
            }
        } while (!parseSuccess);
        double hSide = doubleValue;

        area = ((aSide + bSide) / 2) * hSide;
        Console.WriteLine("\nTrapecoid's area ia: {0,8:#.###}.\n", area);
    }
}
