using netcore_webapi_practice.Models;
using netcore_webapi_practice.Repository;

namespace netcore_webapi_practice.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _productRepository.GetProductById(productId);
        }

        public async Task<Product> AddProduct(Product product)
        {
            return await _productRepository.AddProduct(product);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateProduct(product);
        }

        public async Task DeleteProduct(int productId)
        {
            await _productRepository.DeleteProduct(productId);
        }
    }
}
