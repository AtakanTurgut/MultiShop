﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

namespace MultiShop.Order.Application.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCQRSRegistiration(this IServiceCollection services)
        {
            services.AddScoped<GetAddressQueryHandler>();
            services.AddScoped<GetAddressByIdQueryHandler>();
            services.AddScoped<CreateAddressCommandHandler>();
            services.AddScoped<UpdateAddressCommandHandler>();
            services.AddScoped<RemoveAddressCommandHandler>();

            services.AddScoped<GetOrderDetailQueryHandler>();
            services.AddScoped<GetOrderDetailByIdQueryHandler>();
            services.AddScoped<CreateOrderDetailCommandHandler>();
            services.AddScoped<UpdateOrderDetailCommandHandler>();
            services.AddScoped<RemoveOrderDetailCommandHandler>();
        }

        public static void ConfigureMediatorRegistiration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceExtension).Assembly));
        }
    }
}
