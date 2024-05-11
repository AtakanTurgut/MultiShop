using Microsoft.Extensions.DependencyInjection;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.BusinessLayer.Concrete;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.BusinessLayer.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICargoCompanyDal, EfCargoCompanyDal>();
            services.AddScoped<ICargoCustomerDal, EfCargoCustomerDal>();
            services.AddScoped<ICargoDetailDal, EfCargoDetailDal>();
            services.AddScoped<ICargoOperationDal, EfCargoOperationDal>();
        }

        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<ICargoCompanyService, CargoCompanyManager>();
            services.AddScoped<ICargoCustomerService, CargoCustomerManager>();
            services.AddScoped<ICargoDetailService, CargoDetailManager>();
            services.AddScoped<ICargoOperationService, CargoOperationManager>();
        }
    }
}
