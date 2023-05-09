using ProductStore.Domain.Models;

namespace ProductStore.Domain.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProduct();

        Task<Product> InsertProduct(Product product);

        Task<Product> UpdateProduct(Product product);

        Task<bool> DeleteProduct(Product product);

        Task<Product> GetProductById(long id);
    }
}
