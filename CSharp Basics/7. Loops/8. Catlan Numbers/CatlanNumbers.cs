using System;
using System.Numerics;

class CatlanNumbers
{
    static void Main()
    {
        Console.Write("Enter positive integer number for n [1<n<100]: ");
        int nNumber = int.Parse(Console.ReadLine());
        BigInteger endCatlansValue = 1;
        BigInteger beforeEndCatlansValue = 1;

        for (int index = 2; index <= nNumber; index++)
        {
            beforeEndCatlansValue = endCatlansValue;
            endCatlansValue = ((2 * ((2 * index) - 1)) * beforeEndCatlansValue / (index + 1));
        }
        Console.WriteLine(endCatlansValue);
    }
}
