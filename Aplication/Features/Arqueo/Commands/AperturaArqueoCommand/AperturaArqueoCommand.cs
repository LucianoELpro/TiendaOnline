using Aplication.Interfaces;
using Aplication.Wrappers;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Entry = Domain.Entities;

namespace Aplication.Features.Arqueo.Commands.AperturaArqueoCommand
{
    public class AperturaArqueoCommand : IRequest<Response<int>>
    {
        public int IdUsuario { get; set; }
        public string IdMasterCaja { get; set; }
    }

    public class AperturaArqueoCommandHandler : IRequestHandler<AperturaArqueoCommand, Response<int>>
    {
        private readonly IMapper _mapper;
        private readonly IArqueoRepository _repository;

        public AperturaArqueoCommandHandler(IMapper mapper, IArqueoRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<Response<int>> Handle(AperturaArqueoCommand request, CancellationToken cancellationToken)
        {
            var newRegister = _mapper.Map<Entry.Arqueo>(request);
            var newId =  await _repository.AperturaArqueo(newRegister);

            return new Response<int>(newId);
        }
    }
}
