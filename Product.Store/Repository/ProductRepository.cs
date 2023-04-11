using Microsoft.EntityFrameworkCore;
using ProductStore.Domain.Models;
using ProductStore.Domain.Repository;
using ProductStore.Persistence;

namespace ProductStore.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDBContext context) : base(context) { }

        public async Task<List<Product>> GetAllProduct(Product product)
        {
            return await _context.Products.ToListAsync();
        }
    }
}
