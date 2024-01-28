using Microsoft.EntityFrameworkCore;
using Store.Data.Repositories.Contract;
using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(StoreDbContext storeDbContext) : base(storeDbContext)
        {
        }

        public async Task<int> CreateOrder(Order order)
        {
             await _context.AddAsync(order);
            return order.Id;
        }

        public async Task<List<Order>> GetAllOrdersByUser(int userId)
        {
            return await _context.Orders.Where(c => c.userId == userId).ToListAsync();
        }
    }
}
