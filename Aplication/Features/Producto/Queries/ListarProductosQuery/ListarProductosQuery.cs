using Aplication.DTOs;
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

namespace Aplication.Features.Producto.Queries.ListarProductosQuery
{
    public class ListarProductosQuery : IRequest<Response<List<ProductoDto>>>
    {
        public string Nombre { get; set; }
    }
    public class ListarProductosQueryHandler : IRequestHandler<ListarProductosQuery, Response<List<ProductoDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IProductoRepository _repository;
        public ListarProductosQueryHandler(IMapper mapper, IProductoRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Response<List<ProductoDto>>> Handle(ListarProductosQuery request, CancellationToken cancellationToken)
        {
            var list = await _repository.ListarProducto(request.Nombre);
            var dtoList = _mapper.Map<List<ProductoDto>>(list);
            return new Response<List<ProductoDto>>(dtoList);

        }
    }
}
