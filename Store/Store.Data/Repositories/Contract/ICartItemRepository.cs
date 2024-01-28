using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories.Contract
{
    public interface ICartItemRepository
    {
        public Task<List<CartItem>> GetByUser(int userId);

        public Task<int> AddItem(CartItem item);

        public Task<int> DeleteItem(int id);

        public Task<int> UpdateItem(CartItem item);
    }
}
