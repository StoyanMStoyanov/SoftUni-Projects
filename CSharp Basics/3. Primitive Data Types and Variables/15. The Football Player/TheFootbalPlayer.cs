using System;

class TheFootbalPlayer
{
    static void Main()
    {        
        char leapYear = char.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double weekends = ((52 - h) * 2) / 3;
        double holidays = p / 2;
        int year = (leapYear == 't' ? 3 : 0);
        
        Console.WriteLine(h + weekends + holidays + year);
    }
}
