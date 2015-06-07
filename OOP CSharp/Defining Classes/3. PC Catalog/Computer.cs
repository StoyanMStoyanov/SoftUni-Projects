using System;
using System.Text;
using System.Collections.Generic;

class Computer
{
    //Fields
    private string name;
    private decimal price;
    private List<Component> components;

    //Constructors
    public Computer(string name)
    {
        this.Name = name;
        this.components = new List<Component>();
    }
    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.components = components;
        CalculatePrice(components);
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
            string temp = IsValid(value);
            if (temp.Length >= 3 || temp != null)
                this.name = temp;
            else
                throw new ArgumentException("The computer name must be more from three characters.");
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        private set
        {
            this.price += value;            
        }
    }

    //Methods
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Sample computer descriptions");
        sb.AppendLine(string.Format("Computer name: {0}", this.Name));
        sb.AppendFormat("Total price: {0}lv.\n", this.Price);
        return sb.ToString();
    }
    public string FullDetails()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Full computer description");
        sb.AppendLine(string.Format("Computer name: {0}", this.Name));        
        foreach (var item in this.components)
        {
            sb.Append(item.ToString());
        }
        sb.AppendFormat("Total price: {0:f2}lv.\n", this.Price);
        return sb.ToString();
    }
    private void CalculatePrice(List<Component> components)
    {
        foreach (var componet in components)
        {
            this.Price = componet.Price;
        }
    }
    public void AddCompoent(string componentName, decimal componentPrice)
    {
        this.components.Add(new Component(componentName, componentPrice));
        this.Price = componentPrice;
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
}
