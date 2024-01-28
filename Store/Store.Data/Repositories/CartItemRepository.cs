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
    public class CartItemRepository : BaseRepository,ICartItemRepository
    {
        public CartItemRepository(StoreDbContext storeDbContext) : base(storeDbContext)
        {
        }

        public async Task<int> AddItem(CartItem item)
        {
            await _context.AddAsync(item);
            return item.Id;
        }

        public async Task<int> DeleteItem(int id)
        {
            var cartToDelete = await _context.Carts.FindAsync(id);
            if (cartToDelete != null) { _context.Carts.Remove(cartToDelete); }
            return id;
            
        }

        public async Task<List<CartItem>> GetByUser(int userId)
        {
            return await _context.Carts.Where(c => c.userId == userId).ToListAsync();
        }

        public async Task<int> UpdateItem(CartItem item)
        {
             _context.Carts.Update(item);
            await _context.SaveChangesAsync();
            return item.Id;
        }
    }
}
