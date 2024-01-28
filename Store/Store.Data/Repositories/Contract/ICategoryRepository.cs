using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories.Contract
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetAll();

        public Task<Category> GetById(int id);

        public Task<int> AddCategory(Category category);

        public Task<int> Update(Category request);

        public Task<Category> DeleteCategory(int id);
    }
}
