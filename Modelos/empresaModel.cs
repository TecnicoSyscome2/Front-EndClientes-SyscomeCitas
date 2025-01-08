using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{
    public class empresaModel
    { 
            public int IdEmpresa { get; set; }


            public string? NombreEmpresa { get; set; }

            [EmailAddress]
            public string? Correo { get; set; }

            public string? Telefono { get; set; }

            public int? Pais { get; set; }

            public string? Contacto { get; set; }

            public string? ClavePrincipal { get; set; }
            public string? NombreAsesor { get; set; }

            public string? HostSmtp { get; set; }

            public string? PortSmtp { get; set; }

            public string? SllSmtp { get; set; }

            public string? UsuarioSmtp { get; set; }

            public string? ContraseñaSmtp { get; set; }
    }
}
