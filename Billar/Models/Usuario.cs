using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billar.Models
{
    public class Usuario
    {
        public int Id { get; set; }  // Clave primaria (no nula)

        public string? NombreUsuario { get; set; }  // Nombre de usuario (nullable)

        public string? Password { get; set; }  // Contraseña (nullable)

        public bool? TipoUsuario { get; set; }  // Tipo de usuario (nullable, bit en SQL Server)

        public bool? Estado { get; set; }  // Estado del usuario (nullable, bit en SQL Server)

        public string? Nombre { get; set; }  // Nombre (nullable)

        public string? Apellido { get; set; }  // Apellido (nullable)
                                               // Colección de ventas asociadas
        public ICollection<Venta> Ventas { get; set; }
        // Relación con Detalle_Caja (Uno a Muchos)
        public ICollection<Detalle_Caja> Detalle_Caja { get; set; }
    }

}
