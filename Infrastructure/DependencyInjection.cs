using Domain.Interfaces.DataContexts;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IDataContext, DataContext>();
        services.AddTransient<IProductRepository, ProductRepository>();

        return services;
    }
}