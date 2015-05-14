using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int melons = 0;
        int watermelons = 0;
        DayOfWeek day = 0;
        for (int index = s; index < s + d; index++)
        {
            day = (DayOfWeek)(index%7);
            switch (day)
            {
                case DayOfWeek.Friday:
                    melons += 2;
                    watermelons += 2;
                    break;
                case DayOfWeek.Monday:
                    watermelons += 1;
                    break;
                case DayOfWeek.Saturday:
                    watermelons += 1;
                    melons += 2;
                    break;
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Thursday:
                    watermelons += 2;
                    break;
                case DayOfWeek.Tuesday:
                    melons += 2;
                    break;
                case DayOfWeek.Wednesday:
                    watermelons += 1;
                    melons += 1;
                    break;
                default:
                    break;
            }
        }
        if (melons == watermelons) Console.WriteLine("Equal amount: {0}", melons);
        else if (melons > watermelons) Console.WriteLine("{0} more melons", melons - watermelons);
        else Console.WriteLine("{0} more watermelons", watermelons - melons);
    }
}
