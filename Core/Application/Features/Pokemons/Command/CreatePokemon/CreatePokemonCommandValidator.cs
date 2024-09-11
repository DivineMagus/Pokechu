using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Pokemons.Command.CreatePokemon
{
    public class CreatePokemonCommandValidator : AbstractValidator<CreatePokemonCommandRequest>
    {
        public CreatePokemonCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithName("Title");

            RuleFor(x => x.Description).NotEmpty().WithName("Description");

            RuleFor(x => x.PokeCenterId).GreaterThan(0).WithName("PokeCenter");

            RuleFor(x => x.Price).GreaterThan(0).WithName("Price");

            RuleFor(x => x.CategoryIds).NotEmpty().Must(categories => categories.Any()).WithName("Categories");
        }
    }
}
