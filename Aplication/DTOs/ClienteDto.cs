using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.DTOs
{
    public class ClienteDto
    {
        public int IdCliente { get; set; }
        public string IdMasterTipoPersona { get; set; }

        public string Nombre { get; set; }

        public string AppePaterno { get; set; }
        public string AppeMaterno { get; set; }
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string IdMasterGenero { get; set; }

        public string Email { get; set; }

        public DateTime FechaNac { get; set; }
        
    }
}
