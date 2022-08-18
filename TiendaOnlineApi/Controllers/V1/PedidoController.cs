using Aplication.Features.Pedido.Commands;
using Aplication.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TiendaOnlineApi.Controllers.V1
{
    [ApiVersion("1.0")]
    public class PedidoController : BaseApiController
    {

        [HttpPost]
        public async Task<IActionResult> CrearPedido(CrearPedidoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
