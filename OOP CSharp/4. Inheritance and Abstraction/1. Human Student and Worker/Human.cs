using System;
using System.Collections.Generic;

abstract class Human
{
    //Fields
    private string firstName;
    private string lastName;

    //Constructors
    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    //Properties
    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("first name", "The name must be minimum 3 characters long. ");
            this.firstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("last name", "The name must be minimum 3 characters long. ");
            this.lastName = value;
        }
    }

    //Methods
    public override string ToString()
    {
        return this.FirstName + " " + this.LastName;
    }
}
