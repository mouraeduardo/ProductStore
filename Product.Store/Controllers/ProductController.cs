using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductStore.Domain.Models;
using ProductStore.Domain.Services;

namespace ProductStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("GetProducts")]
        [HttpGet]
        public async Task<ActionResult> GetAllProduct()
        {
            List<Product> products = await _productService.GetAllProduct();
            return Ok(products);
        }
    }
}
