using Aplication.Enums;
using Aplication.Features.Clientes.Commands.CrearClienteCommand;
using Aplication.Features.Clientes.Queries.BuscarClienteQuery;
using Aplication.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TiendaOnlineApi.Controllers.V1
{
    [ApiVersion("1.0")]
    public class ClienteController : BaseApiController
    {

        [HttpGet()]
        [Authorize]
        public async Task<IActionResult> BuscarCliente(string nombre)
        {
            return Ok(await Mediator.Send(new BuscarClienteQuery { Nombre=nombre}));
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CrearCliente(CrearClienteCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
