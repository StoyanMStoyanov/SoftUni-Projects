using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter some time [hh:mm]: ");
        DateTime time = DateTime.Now;
        if (DateTime.TryParse(Console.ReadLine(), out time))
        {
            if ((time.Hour >= 0 && time.Hour < 3) || (time.Hour >= 13 && time.Hour < 24 )) 
                Console.WriteLine("Beer time.");
            else 
                Console.WriteLine("Non-beer time.");
        }
        else Console.WriteLine("Invalid time.");
    }
}
