using ProductStore.Domain.Models;
using ProductStore.Domain.Repository;
using ProductStore.Domain.Services;

namespace ProductStore.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<Product>> GetAllProduct()
        {
            return _productRepository.GetAllProduct();
        }
    }
}
