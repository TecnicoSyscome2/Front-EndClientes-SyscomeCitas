using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{
    public class CitasDetModel
    {     
            public int IdCitaDet { get; set; }

            public int? IdCita { get; set; }

            public long? Producto { get; set; }

            public int? Cantidad { get; set; }

            public decimal? ValorTotal { get; set; }

        public virtual ProductosModel? Productos { get; set; }
        public virtual CitasModel? Citas { get; set; }
    }
}
