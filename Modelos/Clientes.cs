using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{
    public class Clientes
    {
        public long Id { get; set; }

        public string? Nombre { get; set; }

        public string? Email { get; set; }

        public string? Telefono { get; set; }

      public string? TipoUsuario { get; set; }
    }
}