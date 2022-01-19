using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.DependencyInjection
{
    public static class DependancyInjection
    {
        public static void DAL_DI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<DatabaseContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), m => m.MigrationsAssembly("DAL"));
            });

          



        }
    }
}
