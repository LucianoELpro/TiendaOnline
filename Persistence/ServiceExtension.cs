using Aplication.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceExtension
    {
        public static void AddInfraestructurePersistence(this IServiceCollection service)
        {
            service.AddTransient(typeof(IArqueoRepository),typeof(ArqueoRepository));
            service.AddTransient(typeof(IClienteRepository), typeof(ClienteRepository));
            service.AddTransient(typeof(IPedidoRepository), typeof(PedidoRepository));
            service.AddTransient(typeof(IProductoRepository), typeof(ProductoRepository));
        }
    }
}
