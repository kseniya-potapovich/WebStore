using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Dto;
using Store.Service.Contract;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDto>>> GetAll()
        {
            return await _categoryService.GetAll();
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<CategoryDto>> GetById(int id)
        {
            return await _categoryService.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddCategory([FromBody] CategoryDto category)
        {
            return await _categoryService.AddCategory(category);
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(CategoryDto request)
        {
            return await _categoryService.Update(request);
        }

        [HttpDelete]
        public async Task<ActionResult<CategoryDto>> DeleteCategore(int id)
        {
            return await _categoryService.DeleteCategory(id);
        }
    }
}
