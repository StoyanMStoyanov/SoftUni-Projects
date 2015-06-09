using System;

namespace Points
{
    class DistanseCalculartorMain
    {
        static void Main()
        {
            Decart3DPoint point1 = new Decart3DPoint(25.0, 15.0, 5.0);
            Decart3DPoint point2 = new Decart3DPoint(10, 12, 5);
            Console.WriteLine("{0:f4}", DistanceCalculator.CalculateDistance(point1, point2));
        }
    }
}
