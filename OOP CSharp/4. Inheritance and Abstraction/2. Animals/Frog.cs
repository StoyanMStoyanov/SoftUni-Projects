using System;

class Frog:Animals, ISoundProdusible
{
    public Frog(string name, int age)
        : base(name, age, "Male")
    {
    }

    public void ProduceSound()
    {
        Console.WriteLine("Kwa, kwa.");
    }
}
