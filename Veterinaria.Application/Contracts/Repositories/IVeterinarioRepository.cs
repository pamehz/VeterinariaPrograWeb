using Veterinaria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Application.Contracts.Repositories
{
    public interface IVeterinarioRepository : IRepository<Veterinario>
    {
        // Agrega aquí métodos específicos relacionados con la gestión de veterinarios si es necesario.
        void Insert(Veterinario veterinario);
    }
}
