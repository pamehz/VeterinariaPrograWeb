using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Domain.InputModels
{
    public class ExistingVeterinario
    {
        public ExistingVeterinario() { }

        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
