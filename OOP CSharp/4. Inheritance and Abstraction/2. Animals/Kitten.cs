using System;

class Kitten : Animals, ISoundProdusible
{
    public Kitten(string name, int age)
        : base(name, age, "Female")
    {
    }

    public void ProduceSound()
    {
        Console.WriteLine("Miayyyy..");
    }
}