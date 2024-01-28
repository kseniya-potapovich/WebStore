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
    public class CategoryRepository: BaseRepository, ICategoryRepository
    {
        public CategoryRepository(StoreDbContext context) : base(context)
        {
        }

        public async Task<int> AddCategory(Category category)
        {
            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return category.Id;
        }

        public async Task<Category> DeleteCategory(int id)
        {
            var categoryToDelete = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (categoryToDelete != null)
            {
                _context.Categories.Remove(categoryToDelete);
                _context.SaveChanges();
                return categoryToDelete;
            }
            return null;
        }

        public async Task<List<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            /* if (category == null)
             {
                 throw new Exception("Category is not exist");
             }*/
            return category;
        }

        public async Task<int> Update(Category request)
        {
            _context.Categories.Update(request);
            await _context.SaveChangesAsync();
            return request.Id;
        }
    }
}
