using System;
using System.Numerics;

class NKCombinations
{
    static void Main()
    {
        Console.Write("Enter positive integer number for K [1<K<100]: ");
        int kNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter integer number for N [K<N<100]: ");
        int nNumber = int.Parse(Console.ReadLine());
        BigInteger nFactoriel = 1;
        BigInteger kFaktoriel = 0;
        BigInteger[] facturials = new BigInteger[nNumber + 1];
        facturials[0] = nFactoriel;
        
        for (int index = 1; index <= nNumber; index++)
        {
            facturials[index] = facturials[index - 1] * index;
        }
        kFaktoriel = facturials[kNumber];
        nFactoriel = facturials[nNumber];
        
        Console.WriteLine("K! = {0};   N! = {1};   (N-K)! = {2:}\nThe number of ways is: {3}",
            kFaktoriel, nFactoriel, facturials[nNumber - kNumber], nFactoriel / (kFaktoriel * facturials[nNumber - kNumber]));
    }
}
