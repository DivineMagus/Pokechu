using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke.Application.Features.PokeCenter.Query.GetPokeCenter
{
    public class GetPokeCenterQueryHandler : IRequestHandler<GetPokeCenterQueryRequest, GetPokeCenterQueryResponse>
    {
        public GetPokeCenterQueryHandler()
        {

        }

        public Task<GetPokeCenterQueryResponse> Handle(GetPokeCenterQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
