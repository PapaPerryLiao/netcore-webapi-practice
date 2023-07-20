using netcore_webapi_practice.Models;

namespace netcore_webapi_practice.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
