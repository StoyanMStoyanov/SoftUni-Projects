using System;
using System.Collections.Generic;

class Worker:Human
{
    //Fields
    private decimal weekSalary;
    private int workHoursPerDay;
    
    //Constructors
    public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    //Properties
    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Week salary", "The Week salary should be greater than zeto.");
            this.weekSalary = value;
        }
    }
    public int WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Work hours", "The Work hours should be greater than zeto.");
            this.workHoursPerDay = value;
        }
    }

    //Methods
    public decimal MoneyPerHour()
    {
        return this.WeekSalary/(this.WorkHoursPerDay*5);
    }
}
