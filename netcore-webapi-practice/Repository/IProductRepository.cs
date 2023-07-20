using netcore_webapi_practice.Models;

namespace netcore_webapi_practice.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
