using Aplication.DTOs;
using Aplication.Interfaces;
using Aplication.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Aplication.Features.Arqueo.Queries.ListarArqueoQuery
{
    public class ListarArqueoQuery : IRequest<Response<List<ArqueoDto>>>
    {
        
        public int idUsuario { get; set; }
        
        public DateTime? FechaIni { get; set; }
        
        public DateTime? Fechafin { get; set; }
        public int Anio { get; set; }
        public int Mes { get; set; }
        public int Anio2 { get; set; }
        public int Mes2 { get; set; }
        public int Dia2 { get; set; }

        public int PageNumber { get; set; }
        public int Pagesize { get; set; }
    }
    
    public class ListarArqueoQueryHandler : IRequestHandler<ListarArqueoQuery,Response<List<ArqueoDto>>>
    {
        private readonly IArqueoRepository _repository;
        private readonly IMapper _mapper;
        public ListarArqueoQueryHandler(IArqueoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Response<List<ArqueoDto>>> Handle(ListarArqueoQuery request, CancellationToken cancellationToken)
        {
            List<Domain.Entities.Arqueo> list = await _repository.ListarArqueo(request);
            var dtoList = _mapper.Map<List<ArqueoDto>>(list);

            return new Response<List<ArqueoDto>>(dtoList);
        }
    }

}
