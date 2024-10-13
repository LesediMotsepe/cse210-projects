using System;

namespace Foundation2;

public class Order
{
 public Customer Customer { get; set; }
    public List<Product> Products { get; set; }

    public Order(Customer customer, List<Product> products)
    {
        Customer = customer;
        Products = products;
    }

    public decimal TotalCost()
    {
        decimal shippingCost = Customer.LivesInUSA() ? 5 : 35;
        decimal productCost = 0;

        foreach (var product in Products)
        {
            productCost += product.TotalCost();
        }

        return productCost + shippingCost;
    }

    public string PackingLabel()
    {
        return string.Join("\n", Products.Select(p => $"{p.Name} (ID: {p.ProductId})"));
    }

    public string ShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address}";
    }
}
