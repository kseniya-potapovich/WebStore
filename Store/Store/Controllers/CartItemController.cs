using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Dto;
using Store.Service.Contract;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddItem(CartItemDto item)
        {
            return await _cartItemService.AddItem(item);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> DeleteItem(int id)
        {
            return await _cartItemService.DeleteItem(id);
        }

        [HttpGet]
        public async Task<ActionResult<List<CartItemDto>>> GetByUser(int userId)
        {
            return await _cartItemService.GetByUser(userId);
        }

        [HttpPut]
        public async Task<ActionResult<int>> UpdateItem(CartItemDto item)
        {
            return await _cartItemService.UpdateItem(item);
        }
    }
}
