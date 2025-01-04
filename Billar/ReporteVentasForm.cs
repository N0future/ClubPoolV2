using Billar.Context;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class ReporteVentasForm : Form
    {
        public ReporteVentasForm()
        {
            InitializeComponent();
        }

        private void ReporteVentasForm_Load(object sender, EventArgs e)
        {
            dgvReporteVentas.AutoGenerateColumns = false;
            CargarData();

        }

        void CargarData()
        {
            // Obtener las fechas seleccionadas en los DateTimePicker
            DateTime fechaDesde = dpDesde.Value.Date;
            DateTime fechaHasta = dpHasta.Value.Date.AddDays(1).AddTicks(-1); // Incluye hasta el final del día seleccionado

            using (var context = new ClubPoolContext())
            {
                // Realizar la consulta filtrada por rango de fechas
                var ventasFiltradas = context.Venta
                  .Where(v => v.Fecha >= fechaDesde && v.Fecha <= fechaHasta) // Filtrar por rango de fechas
                  .OrderByDescending(v => v.Fecha) // Ordenar por fecha descendente
                  .Select(v => new
                  {
                      v.Id,
                      v.Fecha,
                      v.Total,
                      v.MontoEfectivo,
                      v.MontoTarjeta,
                      MesaNombre = v.Mesa.Descripcion,
                      v.MontoMesas,
                      v.MontoConsumo,
                      Usuario = v.Usuario.NombreUsuario // Nombre completo del usuario
                  })
                  .ToList();

                // Asignar los datos al DataGridView
                dgvReporteVentas.DataSource = ventasFiltradas;

                // Calcular el total de ventas en efectivo y tarjeta
                decimal totalEfectivo = ventasFiltradas.Sum(v => v.MontoEfectivo);
                decimal totalTarjeta = ventasFiltradas.Sum(v => v.MontoTarjeta);
                decimal total = totalEfectivo + totalTarjeta;
                decimal totalMesas = ventasFiltradas.Sum(_ => _.MontoMesas);
                decimal totalConsumo = ventasFiltradas.Sum(_ => _.MontoConsumo);
                // Actualizar los labels con los totales formateados
                lblTotalEfectivo.Text = totalEfectivo.ToString("n0"); // Formato de miles
                lblTotalTarjeta.Text = totalTarjeta.ToString("n0");   // Formato de miles
                lblTotal.Text = total.ToString("n0");
                lblTotalMesas.Text = totalMesas.ToString("n0");
                lblTotalConsumo.Text = totalConsumo.ToString("n0");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarData();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo workbook
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Hoja1");

            // Escribir los encabezados de columna
            for (int i = 0; i < dgvReporteVentas.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = dgvReporteVentas.Columns[i].HeaderText;
            }

            // Escribir los datos de las filas
            for (int i = 0; i < dgvReporteVentas.Rows.Count; i++)
            {
                for (int j = 0; j < dgvReporteVentas.Columns.Count; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = dgvReporteVentas.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Crear el nombre del archivo con la fecha y hora actual
            string fechaHora = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nombreArchivo = $"_reporte_ventas_{fechaHora}.xlsx";

            // Guardar el archivo en la ruta especificada
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = nombreArchivo;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Guardar el archivo
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Datos exportados con éxito.");
                }
            }
        }

        private void dgvReporteVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que no se haya hecho clic en el encabezado
            {
                // Obtener el Id de la venta seleccionada (suponiendo que está en la primera columna)
                int idVentaSeleccionada = Convert.ToInt32(dgvReporteVentas.Rows[e.RowIndex].Cells["Id"].Value);

                // Abrir el formulario DetalleVentaReporteForm y pasar el Id de la venta seleccionada
                DetalleVentaReporteForm detalleForm = new DetalleVentaReporteForm(idVentaSeleccionada);
                detalleForm.ShowDialog(); // Mostrar el formulario como un cuadro de diálogo
            }
        }

        private void ReporteVentasForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(57, 128, 227));

        }
    }
}
