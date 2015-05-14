using System;
using System.Numerics;

class NDivideKFactorials
{
    static void Main()
    {
        Console.Write("Enter positive integer number for K [1<K<100]: ");
        int kNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for N [K<N<100]: ");
        int nNumber = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;
        BigInteger kFaktoriel = 0;
        for (int index = 1; index <= nNumber; index++)
        {
            nFactoriel *= index;
            if (index == kNumber) kFaktoriel = nFactoriel;
        }
        Console.WriteLine("K! = {0};\nN! = {1};\nN!/K! = {2}", 
            kFaktoriel, nFactoriel, nFactoriel / kFaktoriel);
    }
}
