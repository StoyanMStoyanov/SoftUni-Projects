using System;
using System.Text;
using System.Collections.Generic;

class Customer:ICloneable
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string idEGN;
    private string permanentAddress;
    private string mobilePhone;
    private string email;
    private List<Payment> payments;
    private CustomerType customerType;

    public Customer(string firstName, string lastName, string idEGN, CustomerType customerType)
        :this(firstName, null, lastName, idEGN, null, null, null, null, customerType)
    {

    }

    public Customer(string firstName, string middleName, string lastName,
        string idEGN, string paymentAddress,
        string mobilephone, string eMail,
        Payment payment, CustomerType customerType
        )
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.IDEGN = idEGN;
        this.PermanentAddress = permanentAddress;
        this.MobilePhone = mobilephone;
        this.Email = email;
        this.payments = new List<Payment>();
        this.Payments = payment;
        this.CustomerType = customerType;
    }


    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            this.firstName = value;
        }
    }
    public string MiddleName
    {
        get
        {
            return this.middleName;
        }
        set
        {
            this.middleName = value;
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
            this.lastName = value;
        }
    }
    public string IDEGN
    {
        get
        {
            return this.idEGN;
        }
        set
        {
            this.idEGN = value;
        }
    }
    public string PermanentAddress
    {
        get
        {
            return this.permanentAddress;
        }
        set
        {
            this.permanentAddress = value;
        }
    }
    public string MobilePhone
    {
        get
        {
            return this.mobilePhone;
        }
        set
        {
            this.mobilePhone = value;
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
            this.email = value;
        }
    }
    public Payment Payments
    {
        get
        {
            return this.payments[0];
        }
        set
        {
            this.payments.Add(value);
        }
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

    public override bool Equals(object obj)
    {
        Customer customer = obj as Customer;
        if (customer == null) 
            return false;

        if (!Object.Equals(this.FirstName, customer.FirstName) ||
            !Object.Equals(this.MiddleName, customer.MiddleName)||
            !Object.Equals(this.LastName, customer.LastName)||
            !Object.Equals(this.IDEGN, customer.IDEGN))
            return false;

        return true;
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() 
            ^ this.IDEGN.GetHashCode() ^ this.CustomerType.GetHashCode();
        
    }

    public override string ToString()
    {        
        return this.IDEGN + " - " + this.FirstName + " " + this.lastName + " - " + this.CustomerType + " customer";
    }

    public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
    {
        return Customer.Equals(firstCustomer, secondCustomer);
    }

    public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
    {
        return (!Customer.Equals(firstCustomer, secondCustomer));
    }
    
    public Customer Clone()
    {
        Customer result = new Customer(this.FirstName, this.MiddleName, this.LastName, 
            this.IDEGN, this.PermanentAddress, this.MobilePhone, this.Email, this.Payments, this.CustomerType);
        return result;
        
    }

    object ICloneable.Clone()
    {
        return this.Clone();
    }

}
