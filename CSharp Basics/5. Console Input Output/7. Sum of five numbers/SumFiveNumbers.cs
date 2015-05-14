using System;
using System.Text.RegularExpressions;

class SumFiveNumbers
{
    static void Main()
    {
        Console.Write("Write five numbers separated with space: ");
        string numbers = Console.ReadLine();
        //Regex pattern = new Regex (@"\s*[0-9]+\s*");
        string[] str = numbers.Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries);
        double sumOfNumbers = 0;
        for (int i = 0; i <str.Length; i++)
        {
            sumOfNumbers = sumOfNumbers + double.Parse(str[i]);
            if (i == str.Length - 1)
            {
                Console.Write("{0} = ", str[i]);
                break;
            }
            Console.Write("{0} + ", str[i]);
            
        }
        Console.WriteLine(sumOfNumbers);
    }

}
