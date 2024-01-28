using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Dto;
using Store.Service.Contract;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetAll()
        {
            return await _productService.GetAll();
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<ProductDto>> GetById(int id)
        {
            return await _productService.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<int>> AddProduct([FromBody] ProductDto product)
        {
            return await _productService.AddProduct(product);
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(ProductDto request)
        {
            return await _productService.Update(request);
        }

        [HttpDelete]
        public async Task<ActionResult<ProductDto>> DeleteProduct(int id)
        {
            return await _productService.DeleteProduct(id);
        }
    }
}
