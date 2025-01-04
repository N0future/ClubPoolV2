using Billar.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billar
{
    public partial class DetalleVentaReporteForm : Form
    {
        private int idVenta;

        public DetalleVentaReporteForm(int _idVenta)
        {
            InitializeComponent();
            idVenta = _idVenta; // Guardar el Id de la venta para usarlo luego
            CargarDetallesVenta(); // Llamar al método que carga los detalles de la venta
        }

        private void CargarDetallesVenta()
        {
            using (var context = new ClubPoolContext())
            {
                // Consulta para obtener los detalles de la venta usando el idVenta
                var detalles = (from v in context.Venta
                                join dv in context.Detalle_Venta on v.Id equals dv.Fk_Id_Venta
                                join p in context.Producto on dv.Fk_Id_Producto equals p.Id
                                where v.Id == idVenta
                                select new
                                {
                                    p.Descripcion,
                                    dv.Cantidad,
                                    p.Precio,
                                    Subtotal = dv.Cantidad * p.Precio,
                                    dv.Fecha
                                }).ToList();

                // Asignar los detalles al DataGridView del DetalleVentaReporteForm
                dgvAperturasYCierres.DataSource = detalles;
            }
        }

        private void DetalleVentaReporteForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));
        }
    }
}
