using System;

class TomCat : Animals, ISoundProdusible
{
    public TomCat(string name, int age)
        : base(name, age, "Male")
    {
    }

    public void ProduceSound()
    {
        Console.WriteLine("Miayy, miayy, miayy.");
    }
}