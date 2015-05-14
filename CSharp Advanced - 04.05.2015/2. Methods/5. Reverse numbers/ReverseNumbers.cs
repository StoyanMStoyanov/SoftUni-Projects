using System;
using System.Text;

class ReverseNumbers
{
    static void Main()
    {
        double[] reversed = {GetReversedNumber(123.45),
                                GetReversedNumber(0.12),
                                GetReversedNumber(256)};
        foreach (var item in reversed)
            Console.WriteLine(item);
    }

    private static double GetReversedNumber(double p)
    {
        string temp = string.Empty;
        for (int index = p.ToString().Length - 1; index >= 0; index--)        
            temp += p.ToString()[index];
        
        return double.Parse(temp);
    }
}
