using Microsoft.Extensions.Options;
using MultiShop.Catalog.Services.CategoryServices;
using MultiShop.Catalog.Services.ProductDetailServices;
using MultiShop.Catalog.Services.ProductImageServices;
using MultiShop.Catalog.Services.ProductServices;
using MultiShop.Catalog.Settings;

namespace MultiShop.Catalog.Infrastructure.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDetailService, ProductDetailManager>();
            services.AddScoped<IProductImageService, ProductImageManager>();
        }
    }
}
