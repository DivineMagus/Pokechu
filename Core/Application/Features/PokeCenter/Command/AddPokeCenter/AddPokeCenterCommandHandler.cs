using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.PokeCenter.Command.AddPokeCenter
{
    public class AddPokeCenterCommandHandler : IRequestHandler<AddPokeCenterCommandRequest, AddPokeCenterCommandResponse>
    {
        public AddPokeCenterCommandHandler()
        {
            //Servis Sınıfı Burada İmplemente Edilir.
        }
        public async Task<AddPokeCenterCommandResponse> Handle(AddPokeCenterCommandRequest request, CancellationToken cancellationToken)
        {
           //Servis İstemi Burada yApılır
        }
    }
}
