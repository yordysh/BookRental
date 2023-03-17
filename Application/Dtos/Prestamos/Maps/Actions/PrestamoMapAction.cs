using Application.Dtos.Solicitantes;
using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.Prestamos.Maps.Actions
{
    internal class PrestamoMapAction : IMappingAction<Prestamo, PrestamoDto>
    {
        public void Process(Prestamo source, PrestamoDto destination, ResolutionContext context)
        {
            if (source.Solicitante != null) destination.Solicitante = context.Mapper.Map<SolicitanteDto>(source.Solicitante);
        }
    }
}
