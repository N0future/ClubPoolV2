using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billar.Models
{
    public class Detalle_Caja
    {
        public int Id { get; set; }
        public int MontoInicio { get; set; }
        public int MontoFinal { get; set; }
        public DateTime Fecha_Apertura { get; set; }
        public DateTime? Fecha_Cierre { get; set; }

        // Llave foránea hacia Caja
        public int Fk_Id_Caja { get; set; }
        public Caja Caja { get; set; }

        // Llave foránea hacia Usuario
        public int Fk_Id_Usuario { get; set; }
        public bool Estado { get; set; }    
        public Usuario Usuario { get; set; }
    }

}
