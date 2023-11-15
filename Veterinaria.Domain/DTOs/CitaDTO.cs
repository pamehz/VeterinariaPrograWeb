using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Domain.DTOs
{
    public class CitaDTO
    {
        private int? parentId;

        public CitaDTO(int id, int veterinarioId, string motivo, DateTime fecha)
        {
            Id = id;
            VeterinarioId = veterinarioId;
            Motivo = motivo;
            Fecha = fecha;
        }

        public CitaDTO(int id, int veterinarioId, string motivo, DateTime fecha, int? parentId) : this(id, veterinarioId, motivo, fecha)
        {
            this.parentId = parentId;
        }

        public int Id { get; private set; }

        public int VeterinarioId { get; private set; }

        public string Motivo { get; private set; }

        public DateTime Fecha { get; private set; }
    }
}
