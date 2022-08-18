using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Producto : AuditableEntityBase
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}
