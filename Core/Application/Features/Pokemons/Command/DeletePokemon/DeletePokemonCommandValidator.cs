using FluentValidation;
using Poke.Application.Features.Pokemons.Command.DeleteProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.Products.Command.DeleteProduct
{
    public class DeletePokemonCommandValidator : AbstractValidator<DeletePokemonCommandRequest>
    {
        public DeletePokemonCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
