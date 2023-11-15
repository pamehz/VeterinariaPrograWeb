using Veterinaria.Domain.DTOs;
using Veterinaria.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Application.Contracts
{
    public interface ICitaService
    {
        CitaDTO Get(int id);

        List<CitaDTO> List();

        bool Insert(NewCita newCita);

        bool Update(ExistingCita existingCita);

        bool Delete(int id);
    }
}
