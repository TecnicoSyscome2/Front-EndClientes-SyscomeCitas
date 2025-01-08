using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{

    public class AsesoresModel
    {

            public long Id { get; set; }


            public string? Nombre { get; set; }

            public int? Especialidad { get; set; }

            public int? EstablecimientosId { get; set; }

            public int? EmpresaId { get; set; }

    }
}
