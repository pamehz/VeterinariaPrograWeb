using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Domain.DTOs;

namespace Veterinaria.Domain.Entities
{
    public class Cita : Entity
    {
        private Cita() { }

        public Cita(int veterinarioId, string motivo, DateTime fecha, int? parentId = null)
        {
            VeterinarioId = veterinarioId;
            Motivo = motivo;
            Fecha = fecha;
            ParentId = parentId;
        }

        [Key]
        [Column("CitaId")]
        public int Id { get; private set; }

        [ForeignKey("Veterinario")]
        public int VeterinarioId { get; private set; }

        public Veterinario Veterinario { get; private set; }

        [MaxLength(200)]
        public string Motivo { get; private set; }

        public DateTime Fecha { get; private set; }

        public DateTime CreateDateTime { get; private set; }

        public DateTime LastChangeDateTime { get; private set; }

        [Column("ParentCitaId")]
        public int? ParentId { get; private set; }

        [ForeignKey("ParentId")]
        public List<Cita> Citas { get; private set; }

        public void Update(string motivo)
        {
            Motivo = motivo;
        }

        public CitaDTO AsDTO()
        {
            return AsDTO(this);
        }

        public static CitaDTO AsDTO(Cita cita)
        {
            return new CitaDTO(cita.Id, cita.VeterinarioId, cita.Motivo, cita.Fecha, cita.ParentId);
        }

    }
}
