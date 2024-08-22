using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.PokeCenter.Command.AddPokeCenter
{
    public class AddPokeCenterCommandRequest : IRequest<AddPokeCenterCommandResponse>
    {
        public string Name { get; set; }
    }
}
