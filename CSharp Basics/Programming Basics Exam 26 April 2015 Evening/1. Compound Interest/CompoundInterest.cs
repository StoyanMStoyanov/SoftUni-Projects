using System;

class CompoundInterest
{
    static void Main()
    {
        decimal p = decimal.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double i = double.Parse(Console.ReadLine());
        decimal f = decimal.Parse(Console.ReadLine());

        //Console.WriteLine(Math.Pow((1.0 + i), n));
        decimal bankLoan = p * (decimal)Math.Pow((1.0 + i), n);
        decimal friendLoan = p * (1 + f);

        if (bankLoan > friendLoan) Console.WriteLine("{0:f2} Friend", friendLoan);
        else Console.WriteLine("{0:f2} Bank", bankLoan);
    }
}
