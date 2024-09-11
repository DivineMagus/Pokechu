using MediatR;
using Microsoft.AspNetCore.Http;
using Poke.Application.Bases;
using Poke.Application.Features.Products.Command.UpdateProduct;
using Poke.Application.Interfaces.AutoMapper;
using Poke.Application.Interfaces.UnitOfWorks;
using Poke.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Pokemons.Command.UpdatePokemon
{
    internal class UpdatePokemonCommandHandler : BaseHandler, IRequestHandler<UpdatePokemonCommandRequest, Unit>
    {
        public UpdatePokemonCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(UpdatePokemonCommandRequest request, CancellationToken cancellationToken)
        {
            var pokemon = await unitOfWork.GetReadRepository<Pokemon>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Pokemon, UpdatePokemonCommandRequest>(request);

            var productCategories = await unitOfWork.GetReadRepository<ProductCategory>().GetAllAsync(x => x.PokemonId == pokemon.Id);

            await unitOfWork.GetWriteRepository<ProductCategory>().HardDeleteRangeAsync(productCategories);

            foreach (var categoryId in request.CategoryIds)
                await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new() { CategoryId = categoryId, PokemonId = pokemon.Id });

            await unitOfWork.GetWriteRepository<Pokemon>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
