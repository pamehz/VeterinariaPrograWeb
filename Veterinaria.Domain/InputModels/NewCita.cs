using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Domain.InputModels
{
    public class NewCita
    {
        public int VeterinarioId { get; set; }

        public string Motivo { get; set; }

        public DateTime Fecha { get; set; }

        public int ParentId { get; set; }
    }
}
