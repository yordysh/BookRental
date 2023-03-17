using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int? EstadoPrestamo { get; set; }
        public int? IdSolicitante { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
        public int? Estado { get; set; } = 1;

        public virtual Solicitante Solicitante { get; set; }
    }
}
