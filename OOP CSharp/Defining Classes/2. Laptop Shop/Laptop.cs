using System;
using System.Text;

class Laptop
{
    //Fields
    private string model;
    private decimal price;
    private string manufacturer;
    private float processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private float screen;
    private Battery battery;
    //Constructors
   
    public Laptop(string model, decimal price)
        : this(model, price, "[not defined]", 0.0f, 0, "[not defined]", "[not defined]", 0f,
        "[not defined]", 0)
    {       
    }

    public Laptop(string model, decimal price, string manifacturer, float screen) :
        this(model, price, manifacturer, 0.0f, 0, "[not defined]", "[not defined]", screen,
        "[not defined]", 0)
    {        
    }

    public Laptop(string model, decimal price, string manifacturer, float processor, 
        int ram, string graphicsCard, string hdd, float screen, string batteryModel, int batteryLife)
    {
        this.Model = model;
        this.Price = price;
        this.Manifacturer = manifacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.battery = new Battery(batteryModel, batteryLife);
    }



    //Properties
    public string Model {
        get
        {
            return this.model;
        }
        set
        {
            this.model = IsValid(value);
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
    public string Manifacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.manufacturer = IsValid(value);
        }
    }
    public float Processor {
        get
        {
            return this.processor;
        }
        set
        {
            if (value >= 0.0)
                this.processor = value;
            else
                throw new ArgumentException("The processor value cannot be smallest from one.");
        }
    }
    public int RAM
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value >= 0)
                this.ram = value;
            else
                throw new ArgumentException("The RAM cannot be smallest from 128MB");
        }
    }
    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = IsValid(value) ;
        }
    }
    public string HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            this.hdd = IsValid(value);
        }
    }
    public float Screen {
        get
        {
            return this.screen;
        }
        set
        {
            this.screen = value;
        }
    }
    public Battery Battery {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }
    
   


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Laptop parameters:");
        sb.AppendLine(string.Format("{0}/{1} -> {2}lv", this.Manifacturer, this.Model, this.Price));
        sb.AppendLine(string.Format("{0}'/{1}GHz/{2}MB/{3}/{4}GB", 
            this.screen, 
            this.Processor, 
            this.RAM, 
            this.GraphicsCard, 
            this.HDD));
        sb.AppendLine(this.Battery.ToString());
        return sb.ToString();
    }

    static string IsValid(string input)
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
            throw new Exception("The name must be min 3 char.");
        }
    }
    static private decimal isValidPrice(decimal tempPrice)
    {
        if (tempPrice > 0) return tempPrice;
        else
            throw new ArgumentOutOfRangeException("The price must be greater than Zero.");
    }
}
