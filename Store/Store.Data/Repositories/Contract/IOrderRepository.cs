using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories.Contract
{
    public interface IOrderRepository
    {
        public Task<int> CreateOrder(Order order);

        public Task<List<Order>> GetAllOrdersByUser(int userId);
    }
}
