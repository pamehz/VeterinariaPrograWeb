using Veterinaria.Application.Contracts.Repositories;
using Veterinaria.Domain.Entities;
using Veterinaria.Persistence.Contexts;

namespace Veterinaria.Persistence.Repositories
{
    public class VeterinarioRepository : Repository<Veterinario>, IVeterinarioRepository
    {
        public VeterinarioRepository(VeterinariaDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
