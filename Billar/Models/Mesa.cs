using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billar.Models
{
    public class Mesa
    {
        public int Id { get; set; }
        public int TipoMesa { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public DateTime? Tiempo { get; set; }
        public int NumMesa { get; set; }

        public int Precio { get; set; }
        public int PrecioMin { get; set; }
    }

}
