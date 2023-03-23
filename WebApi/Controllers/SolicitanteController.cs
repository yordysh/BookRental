using Application.Dtos.Solicitantes;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Utils.Paginations;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SolicitanteController : Controller
    {
        private readonly ISolicitanteService _solicitanteService;

        public SolicitanteController(ISolicitanteService solicitanteService)
        {
            _solicitanteService = solicitanteService;
        }


        [HttpGet]
        public async Task<IEnumerable<SolicitanteDto>> Get()
        => await _solicitanteService.FindAll();


        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SolicitanteDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<NotFound, Ok<SolicitanteDto>>> Get(int id)
        {
            var response = await _solicitanteService.Find(id);

            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SolicitanteDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Results<BadRequest, Ok<SolicitanteDto>>> Post([FromBody] SolicitanteFormDto request)
        {
            var response = await _solicitanteService.Create(request);

            if (response == null) return TypedResults.BadRequest();

            return TypedResults.Ok(response);
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SolicitanteDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Results<BadRequest, NotFound, Ok<SolicitanteDto>>> Put(int id, [FromBody] SolicitanteFormDto request)
        {
            var response = await _solicitanteService.Edit(id, request);

            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SolicitanteDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Results<NotFound, Ok<SolicitanteDto>>> Delete(int id)
        {
            var response = await _solicitanteService.EnableOrDisable(id);

            if (response == null) return TypedResults.NotFound();

            return TypedResults.Ok(response);
        }


        [HttpGet("PaginatedSearch")]
        public async Task<ResponsePagination<SolicitanteDto>> PaginatedSearch([FromQuery] RequestPagination<SolicitanteDto> request)
        => await _solicitanteService.PaginatedSearch(request);
    }
}
