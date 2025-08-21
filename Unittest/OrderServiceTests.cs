using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Question2_B;

[TestClass]
public class OrderServiceTests
{

    [TestMethod]
    public void CreateOrder_ShouldAddOrder()
    {
        var context = new StubApplicationDbContext();
        var service = new OrderService(context);

        var order = new Order();
        order.AddProduct(new Product { Name = "Laptop", Price = 10m, Quantity = 2 });

        service.CreateOrder(order);

        Assert.AreEqual(1, context.Orders.Count());
        Assert.AreEqual(20m, context.Orders.First().TotalPrice);
    }

    [TestMethod]
    public void AddProduct_ShouldIncreaseQuantity_IfExists()
    {
        var order = new Order();
        order.AddProduct(new Product { Name = "Phone", Price = 5m, Quantity = 1 });
        order.AddProduct(new Product { Name = "Phone", Price = 5m, Quantity = 2 });

        Assert.AreEqual(1, order.Products.Count);
        Assert.AreEqual(3, order.Products[0].Quantity);
        Assert.AreEqual(15m, order.TotalPrice);
    }
}
