using System;
using System.Text;

class NumberDividableByNumber
{
    static void Main()
    {
        int startValue = 0, endValue = 0;
        Console.Write("Enter start integer number: ");
        while(!int.TryParse(Console.ReadLine(), out startValue));
        Console.Write("Enter end integer number: ");
        while(!int.TryParse(Console.ReadLine(), out endValue));
        int devider = startValue;
        int count = 0;
        StringBuilder dividableNumbers = new StringBuilder();
        if (startValue > endValue)
        {
            devider = endValue;
            endValue = startValue;
            startValue = devider;
        }
        if (endValue - startValue > 5)
        {
            do
            {
                if (devider % 5 == 0)
                {
                    dividableNumbers.Append(devider + ", ");
                    count++;
                    break;
                }
                devider++;
            } while (true);

            while (devider < endValue)
            {
                devider += 5;
                if (devider > endValue) break;
                dividableNumbers.Append(devider + ", ");
                count++;
            }
            dividableNumbers.Replace(',', '.', dividableNumbers.Length - 2, 1);
            
        }
        else
        {
            for (int i = startValue; i <= endValue; i++)
                if (i % 5 == 0)
                {
                    dividableNumbers.Append(i + ".");
                    count++;
                    break;
                }
            dividableNumbers.Append("-");
            dividableNumbers.Remove(dividableNumbers.Length-1, 1);
        }
        Console.WriteLine("{0}  -  {1}", count, dividableNumbers);
    }
}
