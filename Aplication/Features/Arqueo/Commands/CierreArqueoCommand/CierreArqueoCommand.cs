using Aplication.Interfaces;
using Aplication.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplication.Features.Arqueo.Commands.CierreArqueoCommand
{
    public class CierreArqueoCommand : IRequest<Response<int>>
    {
        public int IdArqueo { get; set; }
        public decimal Real { get; set; }
        public int IdUsuario { get; set; }

    }
    public class CierreArqueoCommandHandler : IRequestHandler<CierreArqueoCommand, Response<int>>
    {
        private readonly IArqueoRepository _repository;
       
        public CierreArqueoCommandHandler(IArqueoRepository repository, IMapper mapper)
        {
            _repository = repository;
           
        }
        public async Task<Response<int>> Handle(CierreArqueoCommand request, CancellationToken cancellationToken)
        {
            var result = await _repository.CierreArqueo(request.IdArqueo, request.Real, request.IdUsuario);

            return new Response<int>(result);
        }
    }
}
