using MediatR;
using Poke.Application.Features.Pokemons.Queries.GetAllProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllPokemonsQueryRequest : IRequest<IList<GetAllPokemonsQueryResponse>>
    {
    }
}
