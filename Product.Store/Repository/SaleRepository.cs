using Microsoft.EntityFrameworkCore;
using ProductStore.Domain.Models;
using ProductStore.Domain.Repository;
using ProductStore.Persistence;

namespace ProductStore.Repository
{
    public class SaleRepository : BaseRepository, ISaleRepository
    {
        public SaleRepository(AppDBContext context) : base(context) { }

        public async Task<List<Sale>> GetAllSales()
        {
            return await _context.Sales.ToListAsync();
        }

        public async Task<Sale> InsertSale(Sale saleModel)
        {

            _context.Sales.Add(saleModel);
            await _context.SaveChangesAsync();

             return saleModel;
        }


    }
}
