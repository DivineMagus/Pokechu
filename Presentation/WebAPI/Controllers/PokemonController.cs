using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poke.Application.Features.Pokemons.Command.CreatePokemon;
using Poke.Application.Features.Pokemons.Command.DeleteProduct;
using Poke.Application.Features.Products.Command.UpdateProduct;
using Poke.Application.Features.Products.Queries;
using Poke.Application.Features.Products.Queries.GetAllProducts;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PokemonController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllPokemons()
        {
            var response = await mediator.Send(new GetAllPokemonsQueryRequest());

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePokemons(CreatePokemonCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> UpdatePokemons(UpdatePokemonCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> DeletePokemons(DeletePokemonCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }
    }
}
