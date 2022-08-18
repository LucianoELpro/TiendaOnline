using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ventas : AuditableEntityBase
    {
        public int IdVentas { get; set; }
        public int IdPedido { get; set; }
    }
}
