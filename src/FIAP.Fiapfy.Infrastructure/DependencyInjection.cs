using FIAP.Fiapfy.Application.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Fiapfy.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAssinaturasRepository, AssinaturaRepository>();

        return services;
    }
}