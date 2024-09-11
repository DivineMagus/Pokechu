using MediatR;
using Microsoft.AspNetCore.Http;
using Poke.Application.Bases;
using Poke.Application.Features.Pokemons.Command.CreatePokemon;
using Poke.Application.Features.Pokemons.Rules;
using Poke.Application.Interfaces.AutoMapper;
using Poke.Application.Interfaces.UnitOfWorks;
using Poke.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Products.Command.CreateProduct
{
    public class CreatePokemonCommandHandler : BaseHandler, IRequestHandler<CreatePokemonCommandRequest, Unit>
    {
        private readonly PokemonRules pokemonRules;

        public CreatePokemonCommandHandler(PokemonRules pokemonRules, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.pokemonRules = pokemonRules;
        }

        public async Task<Unit> Handle(CreatePokemonCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Pokemon> pokemons = await unitOfWork.GetReadRepository<Pokemon>().GetAllAsync();

            await pokemonRules.PokemonNameMustNotBeSame(pokemons, request.Title);

            Pokemon pokemon = new(request.Title, request.Description, request.PokeCenterId, request.Price, request.Discount);

            await unitOfWork.GetWriteRepository<Pokemon>().AddAsync(pokemon);
            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var categoryId in request.CategoryIds)
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        PokemonId = pokemon.Id,
                        CategoryId = categoryId
                    });

                await unitOfWork.SaveAsync();
            }

            return Unit.Value;
        }
    }
}
