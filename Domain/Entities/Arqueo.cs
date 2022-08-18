using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Arqueo : AuditableEntityBase
    {
        public int IdArqueo { get; set; }
        public int IdUsuario { get; set; }
        public string IdMasterCaja { get; set; }
        public DateTime FApertura { get; set; }
        public DateTime FCierra { get; set; }
        public decimal Estimado { get; set; }
        public decimal Real { get; set; }
        public decimal Diferencia { get; set; }

        public string EstadoArqueo { get; set; }

    }
}
