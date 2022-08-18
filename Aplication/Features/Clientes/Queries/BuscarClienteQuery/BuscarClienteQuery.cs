using Aplication.DTOs;
using Aplication.Interfaces;
using Aplication.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Aplication.Features.Clientes.Queries.BuscarClienteQuery
{
    public class BuscarClienteQuery : IRequest<Response<List<ClienteDto>>>
    {
        public string Nombre { get; set; }
    }

    public class BuscarClienteQueryHandler : IRequestHandler<BuscarClienteQuery, Response<List<ClienteDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _repository;
        public BuscarClienteQueryHandler(IMapper mapper, IClienteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<Response<List<ClienteDto>>> Handle(BuscarClienteQuery request, CancellationToken cancellationToken)
        {
            List<Cliente> list =   await _repository.BuscarCliente(request.Nombre);

            var dtoList = _mapper.Map<List<ClienteDto>>(list);

            return new Response<List<ClienteDto>>(dtoList);
        }
    }
}
