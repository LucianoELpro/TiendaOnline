using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PagoPedido : AuditableEntityBase
    {
        public int IdPagoPedido { get; set; }
        public int IdPedido { get; set; }

        public decimal TotalPago { get; set; }

        public DateTime FechaPago { get; set; }
        
    }
}
