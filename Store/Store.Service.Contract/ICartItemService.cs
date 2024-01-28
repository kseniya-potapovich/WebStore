using Store.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Contract
{
    public interface ICartItemService
    {
        public Task<List<CartItemDto>> GetByUser(int userId);

        public Task<int> AddItem(CartItemDto item);

        public Task<int> DeleteItem(int id);

        public Task<int> UpdateItem(CartItemDto item);
    }
}
