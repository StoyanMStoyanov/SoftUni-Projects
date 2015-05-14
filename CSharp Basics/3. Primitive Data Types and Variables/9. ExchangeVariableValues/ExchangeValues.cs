using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExchangeVariableValues
{
    class ExchangeValues
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer value: ");
            int firstValue = int.Parse(Console.ReadLine()); 
            Console.Write("Enter second integer value: ");
            int secondValue = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("First entered value is: {0}, \nSecond entered value is: {1}.\n\n", firstValue, secondValue);
            int tempValue = firstValue;
            firstValue = secondValue;
            secondValue = tempValue;
            Console.Write("First changed value is: {0}, \nSecond changed value is: {1}.\n", firstValue, secondValue);

        }
    }
}
