using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billar.Models
{
    public class Caja
    {
        public int Id { get; set; }
 
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        // Relación con Usuario
        // Relación con Detalle_Caja (Uno a Muchos)
        public ICollection<Detalle_Caja> Detalle_Caja { get; set; }
    }
}
