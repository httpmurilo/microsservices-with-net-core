using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog.API.Entities;

namespace Catalog.API.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task<List<Product>> GetProductByCategory(string categoryName);
        Task Create(Product product);
        Task<bool> Update (Product product);
        Task<bool> Delete (string id);

    }
}