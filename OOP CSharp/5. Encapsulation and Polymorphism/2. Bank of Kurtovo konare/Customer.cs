using System;
using System.Collections.Generic;

public abstract class Customer
{
    private CustomerType customerType;
    public Customer(string firstName, string lastName, CustomerType customerTupe)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.CustomerType = customerTupe;
    }

    public CustomerType CustomerType
    {
        get
        {
            return this.customerType;
        }
        set
        {
            this.customerType = value;

        }
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
