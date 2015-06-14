class Deposit:Account, IDeposit, IWithdraw
{
    public Deposit(string firstName, string lastName, CustomerType customerType, double interestRate)
        :base(firstName, lastName, customerType, interestRate)
    {

    }

    public void WithdrawMoney(decimal money)
    {
        if (this.Balance - money < 0)
            throw new System.ArgumentException("In Account not enought money.");
        this.Balance -= money;
    }

    public override decimal CalculateInterest(int months)
    {
        if(this.Balance > 0 && this.Balance < 1000)
            return this.Balance; 
        
        return this.Balance * (decimal)((1 + (this.InterestRate / 100)) * months);           
        
    }
}
