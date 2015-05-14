using System;
using System.Text;

class PhoneNumber
{
    static void Main()
    {
        int intValue;
        bool parceSucsess = false;
        StringBuilder primeNumbers = new StringBuilder();
        primeNumbers.Append(1 + " ");
        primeNumbers.Append(2 + " ");
        primeNumbers.Append(3 + " ");
        for (int i = 4; i <= 100; i++)
        {
            bool isPrime = false;
            for (int j = 2; j <= (int)Math.Sqrt(i); j++)
            {
                isPrime = i % j == 0 ? true : false;
                if (isPrime) break;
            }
            if (isPrime) continue;
            else primeNumbers.Append(i + " ");
        }

        do
            {
                parceSucsess = false;
                Console.WriteLine("For end press \"0\".");
                Console.Write("Enter integer value from 4 to 100: ");
                parceSucsess = int.TryParse(Console.ReadLine(), out intValue);
                if (parceSucsess && intValue > 3 && intValue <= 100)
                {
                    string prNumbers = primeNumbers.ToString();
                    bool isPrime = false;
                    if ((prNumbers.IndexOf(intValue.ToString())) != -1) isPrime = true;
                    Console.WriteLine("The value {0} is {1}.", intValue, isPrime ? "PRIME" : "NOT PRIME");
                }
                else
                {
                    if (intValue == 0) break;
                    Console.WriteLine("Invalid value, please enter integer value.\nPress Enter for continue.");
                }
                Console.ReadLine();
                Console.Clear();
            } while (true);
       
    }
}
