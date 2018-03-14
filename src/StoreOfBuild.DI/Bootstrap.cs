using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Data;
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Products;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
           services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(connection));            
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));  
            services.AddScoped(typeof(CategoryStorer));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
                
        }
    }
}