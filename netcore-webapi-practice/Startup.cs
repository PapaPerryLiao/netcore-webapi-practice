using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using netcore_webapi_practice.Contexts;

namespace netcore_webapi_practice
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            string connectionString = Configuration.GetConnectionString("NorthwindDbConnection");

            services.AddDbContext<NorthwindDbContext>(option => option.UseSqlServer(connectionString));

        }

    }
}
