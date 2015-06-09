using System;

namespace Points
{
    static class DistanceCalculator
    {
        public static double CalculateDistance(Decart3DPoint point1, Decart3DPoint point2)
        {
            double x = (point2.XCoord - point1.XCoord) * (point2.XCoord - point1.XCoord);
            double y = (point2.YCoord - point1.YCoord) * (point2.YCoord - point1.YCoord);
            double z = (point2.ZCoord - point1.ZCoord) * (point2.ZCoord - point1.ZCoord);
            double temp = Math.Sqrt(x + y + z);
            return temp;
        }
    }
}
