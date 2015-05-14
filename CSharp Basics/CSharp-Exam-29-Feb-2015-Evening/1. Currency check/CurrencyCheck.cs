using System;
using System.Collections.Generic;

class CurrencyCheck
{
    static void Main()
    {
        decimal r = decimal.Parse(Console.ReadLine());
        decimal d = decimal.Parse(Console.ReadLine());
        decimal e = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());

        List<decimal> cheapestGame = new List<decimal>(5); 

        cheapestGame.Add(r / 100 * 3.5M);
        cheapestGame.Add(d * 1.5M);
        cheapestGame.Add( e * 1.95M);
        cheapestGame.Add(b / 2M);
        cheapestGame.Add( m);
        cheapestGame.Sort();

        Console.WriteLine("{0:f2}", cheapestGame[0]);
    }
}
