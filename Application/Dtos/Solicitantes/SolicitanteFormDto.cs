using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Solicitantes
{
    public class SolicitanteFormDto
    {
        public string NombreCompleto { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
