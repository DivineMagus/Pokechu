using MediatR;
using Microsoft.AspNetCore.Http;
using Poke.Application.Bases;
using Poke.Application.Features.Pokemons.Command.DeleteProduct;
using Poke.Application.Interfaces.AutoMapper;
using Poke.Application.Interfaces.UnitOfWorks;
using Poke.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Pokemons.Command.DeletePokemon
{
    public class DeletePokemonCommandHandler : BaseHandler, IRequestHandler<DeletePokemonCommandRequest, Unit>
    {
        public DeletePokemonCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
        }

        public async Task<Unit> Handle(DeletePokemonCommandRequest request, CancellationToken cancellationToken)
        {
            var pokemon = await unitOfWork.GetReadRepository<Pokemon>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            pokemon.IsDeleted = true;

            await unitOfWork.GetWriteRepository<Pokemon>().UpdateAsync(pokemon);
            await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
