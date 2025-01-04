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
    public partial class DetalleAperturaCierreForm : Form
    {
        public DetalleAperturaCierreForm()
        {
            InitializeComponent();
        }

        private void DetalleAperturaCierreForm_Load(object sender, EventArgs e)
        {
            CargarGridCajas(dgvAperturasYCierres);
        }

        public void CargarGridCajas(DataGridView dgvCajas)
        {
            using (var context = new ClubPoolContext())
            {
                var query = (from dc in context.Detalle_Caja
                             join u in context.Usuario on dc.Fk_Id_Usuario equals u.Id
                             join v in context.Venta on dc.Id equals v.Fk_Id_Detalle_Caja into ventas
                             from v in ventas.DefaultIfEmpty() // Esto hace el LEFT JOIN
                             group v by new
                             {
                                 dc.Id,
                                 dc.Fecha_Apertura,
                                 dc.Fecha_Cierre,
                                 u.NombreUsuario,
                                 dc.MontoInicio,
                                 dc.MontoFinal
                             }
                 into g
                             select new
                             {
                                 g.Key.Id,
                                 g.Key.Fecha_Apertura,
                                 g.Key.Fecha_Cierre,
                                 NombreUsuario = g.Key.NombreUsuario,
                                 g.Key.MontoInicio,
                                 g.Key.MontoFinal,
                                 totalVentasEfectivo = g.Sum(x => x != null ? x.MontoEfectivo : 0)
                             }).ToList();

                // Asignar los datos al DataGridView
                dgvCajas.DataSource = query;
            }
        }

        private void DetalleAperturaCierreForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));
        }
    }
}
