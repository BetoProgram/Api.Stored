using Api.Stored.Application.Citas.Commands;
using Api.Stored.Application.Citas.Querys;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Stored.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CitasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCitas()
        {
            return Ok(await _mediator.Send(new ObtenerCitasQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GenerarCitasCommand model)
        {
            await _mediator.Send(model);
            return Ok();
        }
    }
}
