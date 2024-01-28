using Store.Dto;

namespace Store.Service.Contract
{
    public interface IProductService
    {
        public Task<List<ProductDto>> GetAll();

        public Task<ProductDto> GetById(int id);

        public Task<int> AddProduct(ProductDto product);

        public Task<int> Update(ProductDto request);

        public Task<ProductDto> DeleteProduct(int id);
    }
}
