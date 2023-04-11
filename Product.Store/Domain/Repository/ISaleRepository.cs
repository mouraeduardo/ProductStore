using ProductStore.Domain.Models;

namespace ProductStore.Domain.Repository
{
    public interface ISaleRepository
    {
        public Task<List<Sale>> GetAllSales();
        public Task<Sale> InsertSale(Sale saleModel);

    }
}
