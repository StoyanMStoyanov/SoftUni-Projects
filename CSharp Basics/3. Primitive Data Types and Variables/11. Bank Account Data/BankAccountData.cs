using System;
using System.Collections.Generic;

namespace _11.Bank_Account_Data
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Stoyan";
            string middleName = "Myhailov";
            string lasttName = "Stoyanov";
            decimal balance = 1025.35m;
            string bankName = "BDSK";
            string IBAN = "BG59BPBI79401057629601";
            long card1 = 1870020194948408;
            long card2 = 2870020194948408;
            long card3 = 3870020194948408;
            long accountNumber = 25836523;

            Console.WriteLine("User Account Number is: {0}", accountNumber);
            Console.WriteLine("Full user name is: {0} {1} {2}", firstName, middleName, lasttName);
            Console.WriteLine("Bank name is: {0} and IBAN is: {1}", bankName, IBAN);
            Console.WriteLine("Available amount of money is: {0}lw.", balance);
            Console.WriteLine("\nThere are three credit cards:\n   -First card: {0};\n   -second card: {1};\n   -third card: {2}.",
                card1, card2, card3);

        }
    }
}
