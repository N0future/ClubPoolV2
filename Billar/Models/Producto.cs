using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billar.Models
{
    public class Producto
    {
        public int Id { get; set; }              // Clave primaria
        public string Descripcion { get; set; }   // Nombre o descripción del producto
        public int Precio { get; set; }       // Precio del producto
        public string Codigo { get; set; }        // Código único del producto
        public int Cantidad { get; set; }
        public bool Estado { get; set; }    
    }

}
