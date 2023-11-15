using Veterinaria.Application.Contracts.Repositories;
using Veterinaria.Domain.Entities;
using Veterinaria.Domain.InputModels;
using Veterinaria.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Persistence.Repositories
{
    public class CitaRepository : Repository<Cita>, ICitaRepository
    {
        public CitaRepository(VeterinariaDbContext dbContext)
            : base(dbContext)
        {
        }

        public bool Insert(NewCita newCita)
        {
            Cita cita = new Cita(newCita.VeterinarioId, newCita.Motivo, newCita.Fecha, newCita.ParentId);
            Insert(cita);
            return true;
        }
    }
}
