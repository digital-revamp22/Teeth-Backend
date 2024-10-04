using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Teeth.Infrastructure.Data;

namespace Teeth.Infrastructure;

public static class TeethInfraModule
{
    public static void ConfigureTeethInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        Console.WriteLine(connectionString);
        if (string.IsNullOrEmpty(connectionString))
            throw new InvalidOperationException("Connection string not found");
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString ?? throw new InvalidOperationException("Connection string not found"))
        );
    }
}