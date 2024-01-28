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
    public class ProductRepository: BaseRepository, IProductRepository
    {
        public ProductRepository(StoreDbContext context) : base(context)
        {
        }

        public async Task<int> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<Product> DeleteProduct(int id)
        {
            var productToDelete = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                _context.SaveChanges();
                return productToDelete;
            }
            return null;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return product;
        }

        public async Task<int> Update(Product request)
        {
            _context.Products.Update(request);
            await _context.SaveChangesAsync();
            return request.Id;
        }
    }
}
