using Aplication.Features.Producto.Queries.ListarProductosQuery;
using Aplication.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TiendaOnlineApi.Controllers.V1
{
    [ApiVersion("1.0")]
    public class ProductoController : BaseApiController
    {
      

        [HttpGet]
        public async Task<IActionResult> CrearPedido(string nombre)
        {
            return Ok(await Mediator.Send(new ListarProductosQuery { Nombre = nombre}));
        }
    }
}
