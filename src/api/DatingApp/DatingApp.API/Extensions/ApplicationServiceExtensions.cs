using DatingApp.API.Data;
using DatingApp.API.Interfaces;
using DatingApp.API.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Extensions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<ITokenService, TokenService>();
        services.AddDbContext<DataContext>(opt =>
        {
            opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        return services;
    }
}
