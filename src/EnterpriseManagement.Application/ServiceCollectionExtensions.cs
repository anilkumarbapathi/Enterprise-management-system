using Microsoft.Extensions.DependencyInjection;
using EnterpriseManagement.Application.Services;
using EnterpriseManagement.Infrastructure.Repositories;

namespace EnterpriseManagement.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            return services;
        }
    }
}
