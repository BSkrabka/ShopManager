using Microsoft.Extensions.DependencyInjection;
using SM.Core.Services;
using SM.Core.Services.Interfaces;

namespace SM.Core
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCoreCollection(this IServiceCollection services)
        {
            services.AddScoped<IContrahentService, ContrahentService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVatValueService, VatValueService>();

            return services;
        }

    }
}
