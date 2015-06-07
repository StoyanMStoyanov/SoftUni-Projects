using System;
using System.Collections.Generic;

class Persons
{
    static void Main()
    {
        Person personOne = new Person("Stoyan      Stoyanov", 25, "sani@abv.bg");
        Person personTwo = new Person("John Ivanow", 28);
        Console.WriteLine(personOne);
        Console.WriteLine(personTwo);
    }
}
