using Store.Dto;
using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Contract
{
    public interface IOrderService
    {
        public Task<int> CreateOrder(OrderDto order);

        public Task<List<OrderDto>> GetAllOrdersByUser(int userId);
    }
}
