using Aplication.Interfaces;
using Aplication.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aplication.Features.Clientes.Commands.CrearClienteCommand
{
    public class CrearClienteCommand :IRequest<Response<int>>
    {        
        public string IdMasterTipoPersona { get; set; }
        public string Nombre { get; set; }

        public string AppePaterno { get; set; }
        public string AppeMaterno { get; set; }
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string IdMasterGenero { get; set; }

        public string Email { get; set; }

        public DateTime FechaNac { get; set; }
        public int idUsuario { get; set; }
    }
    public class CrearClienteCommandHandler : IRequestHandler<CrearClienteCommand, Response<int>>
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _repository;

        public CrearClienteCommandHandler(IMapper mapper, IClienteRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Response<int>> Handle(CrearClienteCommand request, CancellationToken cancellationToken)
        {
            var newRegister = _mapper.Map<Cliente>(request);
            var idRegister = await _repository.CrearCliente(newRegister);
            return new Response<int>(idRegister);
        }
    }
}
