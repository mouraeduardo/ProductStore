using ProductStore.Domain.Models;

namespace ProductStore.Domain.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProduct(Product product);
    }
}
