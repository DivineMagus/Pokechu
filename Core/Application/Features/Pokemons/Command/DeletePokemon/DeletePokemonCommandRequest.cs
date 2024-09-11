using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Pokemons.Command.DeleteProduct
{
    public class DeletePokemonCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
