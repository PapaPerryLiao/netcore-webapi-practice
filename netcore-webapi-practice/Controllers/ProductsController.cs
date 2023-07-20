using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using netcore_webapi_practice.Models;
using netcore_webapi_practice.Service;

namespace netcore_webapi_practice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            var products = await _productService.GetProducts();
            return Ok(products);
        }
    }
}
