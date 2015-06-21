using System;

class InterestCalculator
{
    private readonly CalculateInterest calculationMethod;

    public InterestCalculator(decimal money, decimal interest, int year, CalculateInterest calculationMethod)
    {
        this.Money = money;
        this.Interest = interest;
        this.Year = year;
        this.calculationMethod = calculationMethod;
    }

    public decimal Money { get; set; }
    public decimal Interest { get; set; }
    public int Year { get; set; }
    public decimal Balance
    {
        get
        {
            decimal result = this.calculationMethod(this.Money, this.Interest, this.Year);
            return result;
        }
    }

    public override string ToString()
    {
        
        return string.Format("Money: {0}, interest: {1}, years: {2}, result: {3:f4}.",
            this.Money, this.Interest, this.Year, this.Balance);
    }
}
