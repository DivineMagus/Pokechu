using Poke.Application.Bases;
using Poke.Application.Features.Pokemons.Exceptions;
using Poke.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Pokemons.Rules
{
    public class PokemonRules : BaseRules
    {
        public Task PokemonNameMustNotBeSame(IList<Pokemon> pokemons, string requestTitle)
        {
            if(pokemons.Any(x => x.Title == requestTitle)) 
                throw new PokemonNameMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
