using Veterinaria.Application.Contracts.Repositories;
using Veterinaria.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Veterinaria.Persistence.Repositories
{
    public static class VeterinariaRepositoryServiceCollectionExtension
    {
        public static IServiceCollection AddVeterinariaRepository<TEntity, TContract, TRepository>
            (this IServiceCollection services)
            where TEntity : Entity
            where TContract : class, IRepository<TEntity>
            where TRepository : class, TContract
        {
            services.AddScoped<TContract, TRepository>();
            return services;
        }
    }
}
