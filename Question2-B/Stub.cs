using System;

namespace Question2_B
{
    public class StubApplicationDbContext : IApplicationDbContext
    {
        private readonly List<Order> _orders = new List<Order>();

        public IQueryable<Order> Orders => _orders.AsQueryable();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void SaveChanges(){}
    }
}
