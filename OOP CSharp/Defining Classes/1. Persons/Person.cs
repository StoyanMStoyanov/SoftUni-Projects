using System;
class Person
{
    private string name;
    private int age;
    private string email;
    //Constructors
    
    public Person(string name, int age, string email)
        :this(name, age)
    {
        this.Email = email;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.age = age;
    }
    
    //Properties
    public string Name {
        get
        {
            return this.name;
        }
        private set
        {
            string temp = value.Trim();
            string[] names = temp.Split(new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries);
            temp = string.Join(" ", names);
            if (temp.Length > 1 && temp.Length <= 100)
            {
                this.name = temp;
            }
            else
            {
                throw new Exception("The name must be min 1 char or max 100chars.");
            }
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        private set
        {
            if (value > 0 && value < 120)
                this.age = value;
            else
                throw new Exception("The Age must be 0 and 120 years.");
        }
    }
    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value == null || value.Contains("@"))
                this.email = value;
            else
                throw new Exception("This is not valid email.");
        }
    }

    //Methods
    public override string ToString()
    {
        return string.Format("Person details are:\nName is: {0}, age: {1}, email: ({2}).",
            this.Name, this.Age, this.Email ?? "[there is no email]");
    }
}
