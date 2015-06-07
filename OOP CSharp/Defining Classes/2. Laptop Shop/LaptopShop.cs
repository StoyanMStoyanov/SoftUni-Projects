using System;
using System.Collections.Generic;

class LaptopShop
{
    static void Main()
    {
        Laptop firstLaptop = new Laptop("ASUS", 1250, "7F7", 15.3f);
        Laptop secondLaptop = new Laptop("Toshiba", 1850, "Z25", 2.5f, 8000, 
            "NVidia", "Western Digital 1TB", 15.3f, "LiPol", 210);
        Console.WriteLine(firstLaptop);
        Console.WriteLine(secondLaptop);
    }
}
