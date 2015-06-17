using System;

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction(22, 7);
        Fraction fraction2 = new Fraction(40, 4);
        Fraction result = fraction1 + fraction2;
        Console.WriteLine(result.Numerator);
        Console.WriteLine(result.Denumerator);
        Console.WriteLine(result);
        Console.WriteLine();
        Fraction resultSubtraction = fraction1 - fraction2;
        Console.WriteLine(resultSubtraction.Numerator);
        Console.WriteLine(resultSubtraction.Denumerator);
        Console.WriteLine(resultSubtraction);
    }
}
