using Aplication.Interfaces;
using Aplication.Wrappers;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Aplication.Features.Pedido.Commands
{
    public class CrearPedidoCommand : IRequest<Response<int>>
    {
       
        public int IdArqueo { get; set; }
        public int IdCliente { get; set; }
        public string IdMasterTipoPedido { get; set; }
        public int IdUser { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
    public class CrearPedidoCommandHandler : IRequestHandler<CrearPedidoCommand, Response<int>>
    {
        private readonly IMapper _mapper;
        private readonly IPedidoRepository _repository;
        public CrearPedidoCommandHandler(IMapper mapper, IPedidoRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<Response<int>> Handle(CrearPedidoCommand request, CancellationToken cancellationToken)
        {
            var newRegister =  _mapper.Map<Domain.Entities.Pedido>(request);
            var idNewRegister = await _repository.CrearPedido(newRegister);
            return new Response<int>(idNewRegister);
        }
    }
}
