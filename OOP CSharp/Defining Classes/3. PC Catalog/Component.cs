using System;
using System.Text;

class Component
{
    //Fields
    private string name;
    private string details;
    private decimal price;

    //Constructors
    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }
    public Component(string name, decimal price, string description)
        :this(name, price)
    {
        this.Details=description;
    }

    //Properties
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = IsValid(value);
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = isValidPrice(value);
        }
    }
    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            this.details = value;
        }
    }

    //Methods
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        return string.Format("Component: {0}, price: {1:f2}lv. {2}\n", this.Name, this.Price, this.details);
    }
    private static string IsValid(string input)
    {

        string temp = input.Trim();
        string[] words = temp.Split(new string[] { " " },
            StringSplitOptions.RemoveEmptyEntries);
        temp = string.Join(" ", words);
        if (temp != null && temp.Length >= 3)
        {
            return temp;
        }
        else
        {
            throw new Exception("The name must be min 3 chars.");
        }
    }
    static private decimal isValidPrice(decimal tempPrice)
    {
        if (tempPrice > 0) return tempPrice;
        else
            throw new ArgumentOutOfRangeException("Price - the price must be greater than Zero.");
    }
}