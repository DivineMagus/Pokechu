using Poke.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Pokemons.Exceptions
{
    public class PokemonNameMustNotBeSameException : BaseException
    {
        public PokemonNameMustNotBeSameException() : base("Pokemon name already existing")
        {
            
        }
    }
}
