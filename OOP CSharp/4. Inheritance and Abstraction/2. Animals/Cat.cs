using System;

class Cat : Animals, ISoundProdusible
{
    public Cat(string name, int age)
        : base(name, age, "Male")
    {
    }

    public void ProduceSound()
    {
        Console.WriteLine("Miay, miay.");
    }
}
