using System;
using System.Collections.Generic;

abstract class Account:Customer, IDeposit
{
    public Account(string firstName, string lastName, CustomerType customer,
        double interestRate)
        :base(firstName, lastName, customer)
    {
        this.InterestRate = interestRate;
    }

    public decimal Balance { get; protected set; }
    public double InterestRate { get; set; }

    public virtual void DepositMoney(decimal money)
    {
        this.Balance += money;
    }

    public virtual decimal CalculateInterest(int months)
    {
        return this.Balance * (decimal)((1 + (this.InterestRate/100)) * months);
    }
}
