using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Solicitantes
{
    public class SolicitanteDto : SolicitanteFormDto
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? Estado { get; set; }
    }
}
