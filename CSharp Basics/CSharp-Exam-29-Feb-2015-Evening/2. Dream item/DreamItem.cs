using System;

class DreamItem
{
    static void Main()
    {
        var str = Console.ReadLine().Split('\\');
        int vorkingDays = DayOfMonth(str[0]);
        var spentMoney = vorkingDays * decimal.Parse(str[1]) * decimal.Parse(str[2]);
        if (spentMoney >= 700) spentMoney *= 1.1M;
        var leftMoney = spentMoney - decimal.Parse(str[3]);
        if(leftMoney >= 0)
            Console.WriteLine("Money left = {0:f2} leva.", leftMoney);
        else
            Console.WriteLine("Not enough money. {0:f2} leva needed.", Math.Abs(leftMoney));
    }
    private static int DayOfMonth(string month)
    {
        int days = 0;
        switch (month)
        {
            case "Feb":
                days = 18;
                break;
            case "Jan":
            case "March":
            case "May":
            case "July":
            case "Aug":
            case "Oct":
            case "Dec":
                days = 21;
                break;
            case "Apr":
            case "June":
            case "Sept":
            case "Nov":
                days = 20;
                break;
        }
        return days;
    }
}
