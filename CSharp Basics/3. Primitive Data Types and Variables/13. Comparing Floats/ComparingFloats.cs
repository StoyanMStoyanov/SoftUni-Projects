using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Comparing_Floats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first double value: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter second double value: ");
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double difference = Math.Abs(b - a);
            
            Console.WriteLine("The values are {0}, precosion is: {1}.", difference <= eps ? "equal" : "unequal", difference);
        }
    }
}
