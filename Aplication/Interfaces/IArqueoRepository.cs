using Aplication.Features.Arqueo.Commands.CierreArqueoCommand;
using Aplication.Features.Arqueo.Queries.ListarArqueoQuery;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IArqueoRepository
    {
        Task<int>  AperturaArqueo(Arqueo arqueo);
        Task<int>  CierreArqueo(int idArqueo,decimal real,int idUsuario);

        Task<List<Arqueo>> ListarArqueo(ListarArqueoQuery predicado);
    }
}
