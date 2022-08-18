using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AuditableEntityBase
    {
        public virtual int Id { get; set; }
        public DateTime Creado { get; set; }
        public int CreadoPor { get; set; }
        public DateTime Modificado { get; set; }
        public int ModificadoPor { get; set; }
        public char Estado { get; set; }
    }
}
