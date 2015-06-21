using System;
using System.Collections.Generic;
using System.Linq;

public delegate decimal CalculateInterest(decimal sumOfMoney, decimal interest, int year);

class InterestCalculatorMain
{
    static void Main()
    {

        InterestCalculator calcul1 = new InterestCalculator(500, 5.6m, 10, CompoundInterest);
        Console.WriteLine("Compound interest:\n" + calcul1);
        InterestCalculator calcul2 = new InterestCalculator(2500, 7.2m, 15, GetSimpleInterest);
        Console.WriteLine("Simple interest:\n" + calcul2);
    }

    public static decimal GetSimpleInterest(decimal sumOfMoney, decimal interest, int year)
    {
        decimal result = sumOfMoney * (1 + ((interest/100) * year));
        return result;

    }

    public static decimal CompoundInterest(decimal sumOfMoney, decimal interest, int year)
    {
        int n = 12;
        double temp = Math.Pow((1 + (double)(interest / 100) / n), year * n);
        decimal result = sumOfMoney * (decimal)temp;
        return result;
    }
}
