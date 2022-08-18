using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pedido : AuditableEntityBase
    {
        public int IdPedido { get; set; }
        public int IdArqueo { get; set; }
        public int IdCliente { get; set; }
        public string IdMasterTipoPedido { get; set; }
        public int IdUser { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime FApertura { get; set; }
        public DateTime FCierre { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalPedido { get; set; }
        public decimal TotalPagado { get; set; }
        public string IdMasterEstadoPedido { get; set; }
        public byte Entrega { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
