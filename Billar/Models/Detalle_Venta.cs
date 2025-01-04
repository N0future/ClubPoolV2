using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billar.Models
{
    public class Detalle_Venta
    {
        public int Id { get; set; } // Llave primaria
        public int Fk_Id_Venta { get; set; } // Llave foránea de la tabla Venta
        public Venta Venta { get; set; } // Navegación a la entidad Venta
        public int Fk_Id_Producto { get; set; } // Llave foránea de la tabla Producto
        public Producto Producto { get; set; } // Navegación a la entidad Producto
        public int Cantidad { get; set; } // Cantidad del producto
        public DateTime Fecha { get; set; }
    }


}
