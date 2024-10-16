using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Foundation2 World!");

      
        var product1 = new Product("Phone", "P001", 500m, 2);
        var product2 = new Product("Laptop", "L001", 1000m, 1);

    
        var customerAddress = new Address("123 Main St", "New York", "NY", "USA");
        var customer = new Customer("John Doe", customerAddress);

        var order = new Order(customer, new List<Product> { product1, product2 });

        
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine("\nTotal Cost:");
        Console.WriteLine(order.TotalCost());
    
    }
}