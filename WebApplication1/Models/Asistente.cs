using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Asistente
    {
        public int Id { get; set; }

        public string tipoDocumento { get; set; }

        public string documento { get; set; }

        public string nombre { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }
    }
}
