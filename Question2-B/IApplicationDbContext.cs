using System;

namespace Question2_B
{
    public interface IApplicationDbContext
    {
        IQueryable<Order> Orders { get; }
        void AddOrder(Order order);
        void SaveChanges();
    }
}
