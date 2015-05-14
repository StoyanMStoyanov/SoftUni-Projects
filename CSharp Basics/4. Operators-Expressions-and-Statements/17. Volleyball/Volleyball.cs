using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double numberOfHolidays = (48 - h) * 0.75;
        double numberOfWeekends =( p * 2) / 3.0;
        double leapYear = (h + numberOfHolidays + numberOfWeekends) *
            (year == "leap" ? 0.15 : 0);
        Console.WriteLine((int)(h + numberOfHolidays+numberOfWeekends+leapYear));
    }
}