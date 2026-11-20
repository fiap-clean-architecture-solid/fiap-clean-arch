using FIAP.Fiapfy.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FIAP.Fiapfy.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<FiapfyDbContext>(options =>
            options.UseSqlite("Data Source=fiapfy.db"));

        services.AddScoped<IAssinaturasRepository, AssinaturaRepository>();

        return services;
    }
}