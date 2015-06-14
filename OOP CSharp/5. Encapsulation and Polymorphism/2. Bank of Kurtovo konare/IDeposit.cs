public interface IDeposit
{
    void DepositMoney(decimal money);
    decimal CalculateInterest(int months);
}
