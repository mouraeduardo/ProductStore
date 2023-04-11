using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductStore.Domain.Models;
using ProductStore.Domain.Repository;


namespace ProductStore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleRepository _saleRepository;

        public SaleController(ISaleRepository saleRepository)
        {
             _saleRepository = saleRepository;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> GetAllSales() 
        {
            if (_saleRepository == null)
            {
                return BadRequest("f");
            } else
            {
                List<Sale> sales = await _saleRepository.GetAllSales();
                return Ok( new {sales});
            } 
        }

        [Authorize]
        [HttpPost]
        public async Task<Sale> InsertSale(Sale saleModel)
        {
            return await _saleRepository.InsertSale(saleModel);
        }
    }
}
