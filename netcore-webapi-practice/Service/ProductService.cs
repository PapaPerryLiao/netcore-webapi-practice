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
    }
}
