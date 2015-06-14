using System;
using System.Collections.Generic;

class BankOfKurtovoKonareMain
{
    static void Main()
    {
        
        Loan account1 = new Loan("Stoyan", "Stoyanov", CustomerType.Individuals, 5.5);
        Console.WriteLine("{0} {1} - {2}lv", account1.FirstName, account1.LastName, account1.Balance);
        account1.DepositMoney(5000);
        Console.WriteLine("{0} {1} - {2}lv", account1.FirstName, account1.LastName, account1.Balance);
        Console.WriteLine("{0} {1} - {2}lv interst for 1 year", 
            account1.FirstName, account1.LastName, account1.CalculateInterest(12));
        Deposit account2 = new Deposit("Stroidizain", "Ltd", CustomerType.Companies, 2.5);
        Console.WriteLine("{0} {1} - {2}lv", account2.FirstName, account2.LastName, account2.Balance);
        account2.DepositMoney(1100);
        Console.WriteLine("{0} {1} - {2}lv", account2.FirstName, account2.LastName, account2.Balance);
        Console.WriteLine("{0} {1} - {2}lv interst for 1 year",
            account2.FirstName, account2.LastName, account2.CalculateInterest(12));
        Mortgage account3 = new Mortgage("Ivan", "Ivanov", CustomerType.Individuals, 1.5);
        Console.WriteLine("{0} {1} - {2}lv", account3.FirstName, account3.LastName, account3.Balance);
        account3.DepositMoney(500);
        Console.WriteLine("{0} {1} - {2}lv", account3.FirstName, account3.LastName, account3.Balance);
        Console.WriteLine("{0} {1} - {2}lv interst for 1 year",
            account3.FirstName, account3.LastName, account3.CalculateInterest(12));
        Loan account4 = new Loan("Vivacom", "AD", CustomerType.Companies, 6.5);
        Console.WriteLine("{0} {1} - {2}lv", account4.FirstName, account4.LastName, account4.Balance);
        account4.DepositMoney(2100);
        Console.WriteLine("{0} {1} - {2}lv", account4.FirstName, account4.LastName, account4.Balance);
        Console.WriteLine("{0} {1} - {2}lv interst for 1 year",
            account4.FirstName, account4.LastName, account4.CalculateInterest(12));
        Deposit account5 = new Deposit("John", "Nikolov", CustomerType.Individuals, 2.25);
        Console.WriteLine("{0} {1} - {2}lv", account5.FirstName, account5.LastName, account5.Balance);
        account5.DepositMoney(1100);
        Console.WriteLine("{0} {1} - {2}lv", account5.FirstName, account5.LastName, account5.Balance);
        Console.WriteLine("{0} {1} - {2}lv interst for 1 year",
            account5.FirstName, account5.LastName, account5.CalculateInterest(12));
        Mortgage account6 = new Mortgage("Stens", "OOD", CustomerType.Companies, 0.5);
        Console.WriteLine("{0} {1} - {2}lv", account6.FirstName, account6.LastName, account6.Balance);
        account6.DepositMoney(1100);
        Console.WriteLine("{0} {1} - {2}lv", account6.FirstName, account6.LastName, account6.Balance);
        Console.WriteLine("{0} {1} - {2}lv interst for 1 year",
            account6.FirstName, account6.LastName, account6.CalculateInterest(12));
    }
}
