using AutoMapper;
using Store.Data.Repositories.Contract;
using Store.Dto;
using Store.Entities;
using Store.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Services
{
    public class OrderService : IOrderService
    {
        public readonly IOrderRepository _orderRepository;

        public readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateOrder(OrderDto order)
        {
            var orderToAdd = _mapper.Map<Order>(order);
            return await _orderRepository.CreateOrder(orderToAdd);
        }

        public async Task<List<OrderDto>> GetAllOrdersByUser(int userId)
        {
            var orders = await _orderRepository.GetAllOrdersByUser(userId);
            return _mapper.Map<List<OrderDto>>(orders);
        }
    }
}
