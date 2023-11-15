using Veterinaria.Domain.Entities;
using Veterinaria.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Application.Contracts.Repositories
{
    public interface ICitaRepository : IRepository<Cita>
    {
        void Delete(Cita cita);
        bool Insert(NewCita newPaciente);
        void Insert(Cita cita);
    }
}
