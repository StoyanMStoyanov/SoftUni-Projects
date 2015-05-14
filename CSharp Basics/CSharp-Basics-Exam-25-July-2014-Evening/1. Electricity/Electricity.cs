using System;

class Electricity
{
    static void Main()
    {
        decimal floorNumber = int.Parse(Console.ReadLine());
        decimal flatsAtFloor = int.Parse(Console.ReadLine());
        var time = Console.ReadLine().Split(':');
        decimal hour = int.Parse(time[0]);
        decimal consumption = 0;
        decimal totalConsumption = 0;
        if (hour >= 0 && hour < 9)
        {
            consumption = (1 * 100.53M) + (8 * 125.9M);
            totalConsumption = floorNumber * flatsAtFloor * consumption;
        }
        else if (hour >= 14 && hour < 19)
        {
            consumption = (2 * 100.53M) + (2 * 125.9M);
            totalConsumption = floorNumber * flatsAtFloor * consumption;
        }
        else if (hour >= 19 && hour < 24)
        {
            consumption = (7 * 100.53M) + (6 * 125.9M);
            totalConsumption = floorNumber * flatsAtFloor * consumption;
        }
        else
            totalConsumption = 0;
        Console.WriteLine("{0} Watts", Math.Floor(totalConsumption));
    }
}