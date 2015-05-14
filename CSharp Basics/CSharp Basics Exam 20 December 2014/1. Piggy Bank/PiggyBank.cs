using System;

class PiggyBank
{
    static void Main()
    {
        int priceTank = int.Parse(Console.ReadLine());
        int partyDays = int.Parse(Console.ReadLine());

        int savedMoney = (30 - partyDays) * 2;
        int spendMoney = partyDays * 5;
        int savesPerMonth = savedMoney - spendMoney;
        if (savesPerMonth < 0) Console.WriteLine("never");
        else
        {
            int neededMonths = priceTank % savesPerMonth > 0 ?
                (priceTank / savesPerMonth) + 1 : priceTank / savesPerMonth;
            int years = neededMonths / 12;
            int months = neededMonths - (years * 12);
            Console.WriteLine("{0} years, {1} months", years, months);
        }
    }
}
