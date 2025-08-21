using System;

namespace Question2_B
{
    public class OrderService
    {
        private readonly IApplicationDbContext _context;

        public OrderService(IApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(Order order)
        {
            _context.AddOrder(order);
            _context.SaveChanges();
        }
    }
}
