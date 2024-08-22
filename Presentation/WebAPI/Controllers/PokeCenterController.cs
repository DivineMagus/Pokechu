using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poke.Application.Features.PokeCenter.Command.AddPokeCenter;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeCenterController : ControllerBase
    {
        private readonly IMediator mediator;

        public PokeCenterController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("AddPokeCenter")]
        public async Task<IActionResult> AddtoDataBase(AddPokeCenterCommandRequest addPokeCenterCommandRequest)
        {
            await mediator.Send(addPokeCenterCommandRequest);
            return StatusCode(StatusCodes.Status201Created);
        }

    }
}
