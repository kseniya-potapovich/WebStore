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
    public class CategoryService: ICategoryService
    {
        public readonly ICategoryRepository _categoryRepository;
        public readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<int> AddCategory(CategoryDto category)
        {
            var existedCategory = await _categoryRepository.GetById(category.Id);
            /*if (existedCategory != null)
            {
                throw new Exception("Category exists");
            }*/
            var categoryToAdd = _mapper.Map<Category>(category);
            return await _categoryRepository.AddCategory(categoryToAdd);
        }

        public async Task<CategoryDto> DeleteCategory(int id)
        {
            var categoryToRemove = await _categoryRepository.DeleteCategory(id);
            return _mapper.Map<CategoryDto>(categoryToRemove);
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            var categories = await _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetById(int id)
        {
            var categoryToFind = await _categoryRepository.GetById(id);
            return _mapper.Map<CategoryDto>(categoryToFind);
        }

        public async Task<int> Update(CategoryDto request)
        {
            var categoryToUpdate = await _categoryRepository.GetById(request.Id);
            /*if (categoryToUpdate == null)
            {
                throw new Exception("Category is not exist");
            }*/
            categoryToUpdate = _mapper.Map<Category>(categoryToUpdate);
            return await _categoryRepository.Update(categoryToUpdate);
        }
    }
}
