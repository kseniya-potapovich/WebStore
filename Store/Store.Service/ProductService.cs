using AutoMapper;
using Store.Data.Repositories.Contract;
using Store.Dto;
using Store.Entities;
using Store.Service.Contract;

namespace Store.Service
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _productRepository;

        public readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<int> AddProduct(ProductDto product)
        {
            var existedProduct = await _productRepository.GetById(product.Id);

            /*if (existedProduct != null)
            {
                throw new Exception("Product exist");
            }*/

            var productToAdd = _mapper.Map<Product>(product);
            return await _productRepository.AddProduct(productToAdd);
        }

        public async Task<ProductDto> DeleteProduct(int id)
        {
            var productToRemove = await _productRepository.DeleteProduct(id);
            return _mapper.Map<ProductDto>(productToRemove);
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = await _productRepository.GetAll();
            return _mapper.Map<List<ProductDto>>(products);
        }

        public async Task<ProductDto> GetById(int id)
        {
            var productToFind = await _productRepository.GetById(id);
            return _mapper.Map<ProductDto>(productToFind);
        }

        public async Task<int> Update(ProductDto request)
        {
            var productToUpdate = await _productRepository.GetById(request.Id);
           /* if (productToUpdate == null)
            {
                throw new Exception("Product is not exist");
            }*/
            productToUpdate = _mapper.Map<Product>(productToUpdate);
            return await _productRepository.Update(productToUpdate);
        }
    }
}
