using System;
using System.Collections.Generic;

class Dog:Animals, ISoundProdusible
{
    public Dog(string name, int age)
        :base(name, age, "Male")
    {
    }
    public void ProduceSound()
    {
        Console.WriteLine("Bay, bay.");
    }
}
