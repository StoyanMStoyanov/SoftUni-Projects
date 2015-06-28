using System;
using System.Collections.Generic;
using System.Linq;

class CustomerMain
{
    static void Main()
    {
        Customer customer1 = new Customer("Stoyan", "Stoyanov", "456789", CustomerType.Diamond);
        Customer customer2 = new Customer("Ivan", "Ivanov", "Simeonov", CustomerType.Diamond);
        Console.WriteLine(customer1);
        Console.WriteLine(customer2);
        Console.WriteLine("Are customers equals: {0}.", Customer.Equals(customer1, customer2));
        Console.WriteLine("Are customers !=: {0}.", customer1 != customer2);
        Console.WriteLine("Are customers ==: {0}.", customer1 == customer2);
        Console.WriteLine("Customer1 hash code: {0}.", customer1.GetHashCode());

        Customer customer3 = customer1.Clone();
        customer3.CustomerType = CustomerType.Golden;
        Console.WriteLine(customer1);
        Console.WriteLine(customer3);
    }
}
