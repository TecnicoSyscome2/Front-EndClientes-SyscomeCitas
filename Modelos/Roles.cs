using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{
    public class rolModel
    {
        public string id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

    }
}
