using MediatR;
using Microsoft.EntityFrameworkCore;
using Poke.Application.DTOs;
using Poke.Application.Features.Products.Queries.GetAllProducts;
using Poke.Application.Interfaces.AutoMapper;
using Poke.Application.Interfaces.UnitOfWorks;
using Poke.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Pokemons.Queries.GetAllProducts
{
    public class GetAllPokemonsQueryHandler : IRequestHandler<GetAllPokemonsQueryRequest, IList<GetAllPokemonsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllPokemonsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetAllPokemonsQueryResponse>> Handle(GetAllPokemonsQueryRequest request, CancellationToken cancellationToken)
        {
            var pokemons = await unitOfWork.GetReadRepository<Pokemon>().GetAllAsync(include: x => x.Include(b => b.PokeCenter));

            var pokeCenter = mapper.Map<PokeCenterDto, Domain.Entities.PokeCenter>(new Domain.Entities.PokeCenter());

            var map = mapper.Map<GetAllPokemonsQueryResponse, Pokemon>(pokemons);

            return map;
        }
    }
}
