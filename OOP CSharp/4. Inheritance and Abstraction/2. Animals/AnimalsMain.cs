using System;

class AnimalsMain
{
    static void Main()
    {
        ISoundProdusible[] animals = 
        {
            new Dog("Sharo", 3),
            new Frog("Karmit", 1),
            new Cat("Some Cat", 4),
            new Kitten("Small kitten", 1),
            new TomCat("Tom", 8)
        };
        foreach (var animal in animals)        
           animal.ProduceSound();       
    }
}
