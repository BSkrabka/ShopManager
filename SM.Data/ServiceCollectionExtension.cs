using Microsoft.Extensions.DependencyInjection;
using SM.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SM.Data.Repositories.Interfaces;
using SM.Data.Repositories;

namespace SM.Data
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDataCollection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SMDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SmDb"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IContrahentRepository, ContrahentRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IVatValueRepository, VatValueRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();

            return services;
        }
    }
}
