using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Domain.DTOs;

namespace Veterinaria.Domain.Entities
{
    public class Veterinario : Entity
    {
        private Veterinario() { }

        public Veterinario(string nombre)
        {
            Nombre = nombre;
        }

        [Column("VeterinarioId")]
        public int Id { get; private set; }

        [MaxLength(50)]
        public string Nombre { get; private set; }

        public void Update(string nombre)
        {
            Nombre = nombre;
        }

        public VeterinarioDTO AsDTO()
        {
            return AsDTO(this);
        }

        public static VeterinarioDTO AsDTO(Veterinario veterinario)
        {
            return new VeterinarioDTO(veterinario.Id, veterinario.Nombre);
        }
    }
}
