using Application.Dtos.Solicitantes;
using System;
namespace Application.Dtos.Prestamos
{
	public class PrestamoDto 
    {
        public int Id { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public int? EstadoPrestamo { get; set; }

        public virtual SolicitanteDto Solicitante { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? Estado { get; set; }
    }
}

