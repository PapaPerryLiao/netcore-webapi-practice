using Azure;
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
        public async Task<ActionResult<ApiResponse<IEnumerable<Product>>>> GetProducts()
        {
            var products = await _productService.GetProducts();
            var response = new ApiResponse<IEnumerable<Product>>(true, products, "Success", 200);

            return Ok(response);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<Product>>> GetProductById(int id)
        {
            var response = new ApiResponse<Product>(false, null, "Product not found", 404);
            var product = await _productService.GetProductById(id);

            if (product == null)
            {
                return NotFound(response);
            }

            response = new ApiResponse<Product>(true, product, "Success", 200);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<Product>>> AddProduct(Product product)
        {
            var newProduct = await _productService.AddProduct(product);
            var response = new ApiResponse<Product>(true, newProduct, "Success", 200);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            if (product == null || id != product.ProductId)
            {
                return BadRequest(new ApiResponse<Product>(false, null, "Invalid request", 400));
            }

            var updatedProduct = await _productService.UpdateProduct(product);
            return Ok(new ApiResponse<Product>(true, updatedProduct, "Product updated", 200));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var existingProduct = await _productService.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound(new ApiResponse<Product>(false, null, "Product not found", 404));
            }

            await _productService.DeleteProduct(id);
            return Ok(new ApiResponse<Product>(true, null, "Product deleted", 200));
        }
    }
}
