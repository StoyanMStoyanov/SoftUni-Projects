using System;
using System.Collections.Generic;

class PCCatalog
{
    static void Main()
    {
        Computer firstComputer = new Computer("Lenovo Yoga");
        Console.WriteLine(firstComputer);
        List<Component> components = new List<Component>(){ 
                                     new Component("Mainboard", 125),
                                     new Component("RAM", 48), 
                                     new Component("CPU", 99.75m, "This is the computer's heart.")};
        Computer secondComputer = new Computer("ASUS F7F", components);
        Console.WriteLine(secondComputer);
        secondComputer.AddCompoent("Graphics card", 27.25m);
        Console.WriteLine(secondComputer);
        Console.WriteLine(secondComputer.FullDetails());
    }
}
