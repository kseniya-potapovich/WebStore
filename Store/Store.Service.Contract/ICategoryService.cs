using Store.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Contract
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAll();

        public Task<CategoryDto> GetById(int id);

        public Task<int> AddCategory(CategoryDto category);

        public Task<int> Update(CategoryDto request);

        public Task<CategoryDto> DeleteCategory(int id);
    }
}
