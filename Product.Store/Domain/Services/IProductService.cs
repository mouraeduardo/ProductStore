using ProductStore.Domain.Models;

namespace ProductStore.Domain.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProduct();
    }
}
