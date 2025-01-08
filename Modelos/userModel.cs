using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{
    [Table("usuariosregistrados", Schema = "dbo")]
    public class userModel : Logins
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int? EmpresaId { get; set; }

        public int? idrol{ get; set; }

        public int? activo { get; set; }

        public DateTime? registerdate { get; set; }
    }
    public enum Estatus_Usuario
    {
        ACTIVO = 1,
        INACTIVO = 2
    }

    public interface Logins
    {
        string Email { get; set; }
        string Password { get; set; }
    }
}
