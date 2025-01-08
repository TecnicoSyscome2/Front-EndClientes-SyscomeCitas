using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{
    public class ProductosModel
    {
            public long Id { get; set; }

            public int? Especialidad { get; set; }

            public string? Descripcion { get; set; }

            public string? Imagen { get; set; }

            public int? TipoPrecio { get; set; }

            public decimal? Precio { get; set; }

            public int? Descuento { get; set; }

            public int? IncluyeIva { get; set; }

            public int? Tiempo { get; set; }

            public int? IdEmpresa { get; set; }

            public virtual empresaModel? Empresa { get; set; }

        
    }
}
