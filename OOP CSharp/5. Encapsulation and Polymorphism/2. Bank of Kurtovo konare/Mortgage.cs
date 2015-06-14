class Mortgage:Account
{
    public Mortgage(string firstName, string lastName, CustomerType customerType, double interestRate)
        : base(firstName, lastName, customerType, interestRate)
    {
    }

    public override decimal CalculateInterest(int months)
    {
        if (this.CustomerType == CustomerType.Companies)
        {
            if (months <= 12) return this.Balance;
            else months -= 12;
        }
        else if (months <= 6) return this.Balance;
        else months -= 6;
        return this.Balance * (decimal)((1 + (this.InterestRate/100)) * months);
    }
}
