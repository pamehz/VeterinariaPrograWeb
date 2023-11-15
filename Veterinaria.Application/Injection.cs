using Veterinaria.Application.Contracts;
using Veterinaria.Application.Diagnostics;
using Veterinaria.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Veterinaria.Application
{
    public static class Injection
    {
        public static IServiceCollection AddApplication
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IVeterinarioService, VeterinarioService>();
            services.AddScoped<ICitaService, CitaService>();

            return services;
        }
    }
}
