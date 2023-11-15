using Veterinaria.Application.Contracts.Contexts;
using Veterinaria.Application.Contracts.Repositories;
using Veterinaria.Domain.Entities;
using Veterinaria.Persistence.Contexts;
using Veterinaria.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Veterinaria.Persistence
{
    public static class Injection
    {
        public static IServiceCollection AddVeterinariaPersistence
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VeterinariaDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IApplicationDbContext>
                (options => options.GetService<VeterinariaDbContext>());

            services.AddVeterinariaRepository<Veterinario, IVeterinarioRepository, VeterinarioRepository>();
            services.AddVeterinariaRepository<Cita, ICitaRepository, CitaRepository>();

            return services;
        }
    }
}
