using System;

class TravellerBob
{
    static void Main()
    {
        bool leapYear = Console.ReadLine() == "leap" ? true : false;
        int c = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        double contractMonth = c * 12.0;
        double familyMonth = f * 4.0;
        double normalMonth = ((12 - (c + f)) * 12) * 0.6;
        double travels = (contractMonth + familyMonth + normalMonth) * (leapYear ? 1.05 : 1.0 );
        Console.WriteLine((int)travels);
    }
}
