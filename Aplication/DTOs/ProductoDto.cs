using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.DTOs
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }

        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}
