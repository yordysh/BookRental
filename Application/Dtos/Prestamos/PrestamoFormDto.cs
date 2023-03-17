using Application.Dtos.Solicitantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Prestamos
{
    public class PrestamoFormDto
    {
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public int? EstadoPrestamo { get; set; }

        public virtual SolicitanteDto Solicitante { get; set; }
    }
}
