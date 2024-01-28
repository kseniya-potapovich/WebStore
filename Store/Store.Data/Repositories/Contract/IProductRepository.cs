using Store.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories.Contract
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAll();

        public Task<Product> GetById(int id);

        public Task<int> AddProduct(Product product);

        public Task<int> Update(Product request);

        public Task<Product> DeleteProduct(int id);
    }
}
