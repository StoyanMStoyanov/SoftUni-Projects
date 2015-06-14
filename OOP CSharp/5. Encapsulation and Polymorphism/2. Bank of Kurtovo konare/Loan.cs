class Loan:Account
{
    public Loan(string firstName, string lastName, CustomerType customerType, double interestRate)
        :base(firstName, lastName, customerType, interestRate)
    {
    }

    public override decimal CalculateInterest(int months)
    {
        if (this.CustomerType == CustomerType.Individuals)
            return this.Balance * (decimal)((1 + (this.InterestRate/100)) * months - 3);
            
        else
            return this.Balance * (decimal)((1 + (this.InterestRate/100)) * months - 2);
    }
}
