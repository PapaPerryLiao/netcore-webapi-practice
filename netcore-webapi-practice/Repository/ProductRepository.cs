using Microsoft.EntityFrameworkCore;
using netcore_webapi_practice.Contexts;
using netcore_webapi_practice.Models;

namespace netcore_webapi_practice.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly NorthwindDbContext _dbContext;

        public ProductRepository(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
