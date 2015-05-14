using System;

namespace _12.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? firstValue = null;
            float? secondValue = null;

            Console.WriteLine("Integer nullable value is: {0}.\nFloat nullable value is: {1}.", firstValue, secondValue);

            firstValue = 5;
            secondValue = 5.25f;
            Console.WriteLine("\nInteger nullable value is: {0}.\nFloat nullable value is: {1}.", firstValue, secondValue);
        }
    }
}
