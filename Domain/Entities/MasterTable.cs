using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class MasterTable : AuditableEntityBase
    {
        public int IdMasterTable { get; set; }
        public string MasterTableParent { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }

        public int Orden { get; set; }

        public string Adicional1 { get; set; }
        public string Adicional2 { get; set; }
        public string Adicional3 { get; set; }

    }
}
