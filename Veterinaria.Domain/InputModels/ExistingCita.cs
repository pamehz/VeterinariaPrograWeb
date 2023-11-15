using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Domain.InputModels
{
    public class ExistingCita
    {
        public int Id { get; set; }

        public string Motivo { get; set; }

        public static implicit operator ExistingCita(DTOs.CitaDTO cita)
        {
            return new ExistingCita
            {
                Id = cita.Id,
                Motivo = cita.Motivo
            };
        }
    }
}
