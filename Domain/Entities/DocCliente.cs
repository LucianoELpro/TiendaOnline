using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DocCliente : AuditableEntityBase
    {
        public int IdDocCliente { get; set; }
        public int IdCliente { get; set; }
        public string IdMasterTipoDoc { get; set; }
        public string Numero { get; set; }
    }
}
