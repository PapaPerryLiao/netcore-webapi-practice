using Microsoft.EntityFrameworkCore;
using netcore_webapi_practice.Models;

namespace netcore_webapi_practice.Contexts
{
    public class NorthwindDbContext: DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
