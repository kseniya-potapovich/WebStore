using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Dto;
using Store.Entities;
using Store.Service.Contract;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> GetAllOrdersByUser(int userId)
        {
            return await _orderService.GetAllOrdersByUser(userId);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateOrder(OrderDto order)
        {
            return await _orderService.CreateOrder(order);
        }
    }
}
