using System;

class WorkHours
{
    static void Main()
    {
        Console.Write("Enter work hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.Write("Enter days available the finish the project: ");
        int days = int.Parse(Console.ReadLine());
        Console.Write("Enter the productivity in percent: ");
        byte percent = byte.Parse(Console.ReadLine());
        Console.WriteLine();
        int sum =(int)(((days * 0.9) * 12) * (percent / 100.0));
        Console.WriteLine("{0}\n{1}",sum - hours < 0 ? "No" : "Yes" , sum - hours);
    }
}
