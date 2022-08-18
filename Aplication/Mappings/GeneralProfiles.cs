using Aplication.DTOs;
using Aplication.Features.Arqueo.Commands.AperturaArqueoCommand;
using Aplication.Features.Clientes.Commands.CrearClienteCommand;
using Aplication.Features.Pedido.Commands;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mappings
{
    public class GeneralProfiles : Profile
    {
        public GeneralProfiles()
        {
            #region Commands
            CreateMap<AperturaArqueoCommand, Arqueo>();
            CreateMap<CrearClienteCommand, Cliente>();
            CreateMap<CrearPedidoCommand, Pedido>();

            #endregion
            //#region Queries
            #region Dtos
            CreateMap<Arqueo,ArqueoDto>();
            CreateMap<Cliente, ClienteDto>();
            CreateMap<Producto, ProductoDto>();
            #endregion

        }
    }
}