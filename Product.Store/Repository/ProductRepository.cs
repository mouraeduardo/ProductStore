using Microsoft.EntityFrameworkCore;
using ProductStore.Domain.Models;
using ProductStore.Domain.Repository;
using ProductStore.Persistence;

namespace ProductStore.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDBContext context) : base(context) { }


        public async Task<List<Product>> GetAllProduct()
        {
            return await _context.Products.ToListAsync();
        }


        public async Task<Product> InsertProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return product;
        }
        public async Task<bool> DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Product> GetProductById(long id)
        {
            return await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
