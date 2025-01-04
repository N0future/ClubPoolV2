using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billar.Models
{
    public class Venta
    {
        public int Id { get; set; }              // Clave primaria
        public DateTime? Hora { get; set; }      // Hora en que se realizó la venta
        public bool Estado { get; set; }         // Estado de la venta (bit)
        public DateTime? Fecha { get; set; }     // Fecha de la venta
        public int Total { get; set; }           // Total de la venta
        public int Fk_Id_Mesa { get; set; }      // Clave foránea para la mesa
        public int MontoMesas { get; set; }
        public int Fk_Id_Caja { get; set; }  
        public int TipoVenta {  get; set; }
        public int MontoConsumo { get; set; }
        public int Fk_Id_Detalle_Caja { get; set; }
        public int Fk_Id_Usuario { get; set; }
        
        public int MontoEfectivo { get; set; } // Nuevo campo para el monto en efectivo
        public int MontoTarjeta { get; set; }
        // Relación con la mesa
        public Mesa Mesa { get; set; }
        // Propiedad de navegación para Detalle_Venta
        // Propiedad de navegación
        public Usuario Usuario { get; set; }
        public ICollection<Detalle_Venta> Detalle_Ventas { get; set; }
        public Caja Caja { get; set; }  // Relación con Caja
    }

}
