using Aplication.DTOs;
using Aplication.Features.Arqueo.Commands.AperturaArqueoCommand;
using Aplication.Features.Arqueo.Commands.CierreArqueoCommand;
using Aplication.Features.Arqueo.Queries.ListarArqueoQuery;
using Aplication.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TiendaOnlineApi.Controllers.V1
{
    [ApiVersion("1.0")]
    
    public class ArqueoController : BaseApiController
    {

        [HttpPost]
        public async Task<IActionResult> AperturaArqueo(AperturaArqueoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> CierreArqueo(CierreArqueoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> ListarArqueo([FromQuery]
         int idUsuario,
         DateTime? FechaIni,
         DateTime? Fechafin,
         int Anio,
         int Mes,
         int Anio2,
         int Mes2,
         int Dia2,
         int PageNumber=0,
         int PageSize=10
            )
        {

            return Ok(await Mediator.Send(new ListarArqueoQuery
            {
                idUsuario = idUsuario,              
                FechaIni =  FechaIni,
                Fechafin =  Fechafin,
                Anio = Anio,
                Mes  = Mes,
                Anio2 = Anio2,
                Mes2 = Mes2,
                Dia2 = Dia2,
                PageNumber = PageNumber,
                Pagesize = PageSize

            }));
        }
    }
}
