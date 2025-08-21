using System;
using System.Collections.Generic;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();

    public decimal TotalPrice => Products.Sum(p => p.Price * p.Quantity);

    public void AddProduct(Product product)
    {
        var existing = Products.FirstOrDefault(p => p.Name == product.Name);
        if (existing != null)
        {
            existing.Quantity += product.Quantity;
        }
        else
        {
            Products.Add(product);
        }
    }

}

