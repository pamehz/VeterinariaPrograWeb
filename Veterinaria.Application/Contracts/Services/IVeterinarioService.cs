using Veterinaria.Domain.DTOs;
using Veterinaria.Domain.InputModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Application.Contracts
{
    public interface IVeterinarioService
    {
        VeterinarioDTO Get(int id);

        List<VeterinarioDTO> List();

        bool Insert(NewVeterinario newVeterinario);

        bool Update(ExistingVeterinario existingVeterinario);

        bool Delete(int id);
    }
}
