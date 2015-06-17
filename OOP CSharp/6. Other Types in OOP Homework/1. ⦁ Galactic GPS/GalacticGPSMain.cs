using System;
using System.Collections.Generic;

class GalacticGPSMain
{
    static void Main()
    {
        Location home = new Location(12.854693, 24.6589652, Planet.Earth);
        Console.WriteLine(home);
    }
}
