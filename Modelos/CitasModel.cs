
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyscomeCitas.Clientes.Modelos
{
    public class CitasModel
    {
        public long Id { get; set; }

        //public long? ClienteId { get; set; }

        public long? AsesorId { get; set; }

        public DateTime? Fecha { get; set; }
        public string Estado { get; set; }


        public int Horas { get; set; }

        public int minutos { get; set; }


        public string Correo { get; set; }

        public int idempresa { get; set; }
    }
    public enum Estado_Citas {
        pendiente,
        confirmada,
        cancelada
       // Finalizada
    }
    public class CitaConDetallesDTO
    {
        public CitasModel Cita { get; set; }
        public List<CitasDetModel> Detalles { get; set; }
    }
}
