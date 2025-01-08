using Billar.Context;
using Billar.Models;
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
    public partial class VentaForm : Form
    {
        public ClubPoolContext context = new ClubPoolContext();
        public decimal totalEfectivo = 0;
        public decimal totalTarjeta = 0;
        public decimal totalAPagar = 0;
        public decimal totalPagado = 0;
        public int userId;
        public VentaForm(int _userId)
        {
            InitializeComponent();
            this.userId = _userId;
        }

        private void CargarProductos()
        {
            using (var context = new ClubPoolContext())
            {
                // Obtener los productos de la base de datos
                var productos = context.Producto.ToList();

                // Asignar los productos al DataGridView
                dgvProductos.AutoGenerateColumns = false;
                dgvProductos.DataSource = productos;
            }


        }
        private void VentaForm_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }


        private void ActualizarTotal()
        {
            decimal totalConsumido = 0;

            // Recorrer todas las filas del dgvConsumo y sumar los subtotales
            foreach (DataGridViewRow row in dgvConsumo.Rows)
            {
                decimal subtotal = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                totalConsumido += subtotal;
            }
            totalAPagar = (int)(totalConsumido);
            // Actualizar los labels con el total consumido y el total de tiempo de la mesa

            lblTotal.Text = "$" + (totalConsumido).ToString("n0"); // Total consumido de productos



        }
        private void btnSumarItem_Click(object sender, EventArgs e)
        {

            // Verificar si hay un producto seleccionado en dgvProductos
            if (dgvProductos.SelectedRows.Count > 0)
            {
                var selectedRow = dgvProductos.SelectedRows[0];
                string Id = selectedRow.Cells["Id"].Value.ToString();
                string descripcion = selectedRow.Cells["Descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(selectedRow.Cells["Precio"].Value);

                // Verificar si el producto ya existe en el dgvConsumo
                foreach (DataGridViewRow row in dgvConsumo.Rows)
                {
                    if (row.Cells["Id2"].Value.ToString() == Id)
                    {
                        // Si ya existe, incrementar la cantidad
                        int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                        row.Cells["Cantidad"].Value = cantidadActual + 1;

                        // Actualizar el subtotal
                        decimal subtotal = Convert.ToInt32(row.Cells["Cantidad"].Value) * precio;
                        row.Cells["Subtotal"].Value = subtotal.ToString("n0");


                        ActualizarTotal();
                        return;
                    }
                }
                // Si el producto no existe, añadirlo al dgvConsumo
                dgvConsumo.Rows.Add(Id, descripcion, precio, 1, precio.ToString("n0"));

                ActualizarTotal();
                LimpiarPagos();

            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para agregar.");
            }



        }
        void LimpiarPagos()
        {
            totalEfectivo = 0;
            totalTarjeta = 0;
            totalPagado = 0;
            dgvPagos.Rows.Clear();
            dgvPagos.DataSource = null;
            lblTotalPagado.Text = "$0";
            lblMontoPendiente.Text = "$0";

        }

        private void btnRestarItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay un producto seleccionado en dgvConsumo
            LimpiarPagos();
            if (dgvConsumo.SelectedRows.Count > 0)
            {
                var selectedRow = dgvConsumo.SelectedRows[0];
                string Id = selectedRow.Cells["Id2"].Value.ToString();
                int cantidadActual = Convert.ToInt32(selectedRow.Cells["Cantidad"].Value);
                int precio = Convert.ToInt32(selectedRow.Cells["Precio2"].Value);

                if (cantidadActual > 1)
                {
                    // Restar una unidad de la cantidad
                    selectedRow.Cells["Cantidad"].Value = cantidadActual - 1;

                    // Actualizar el subtotal
                    decimal subtotal = (cantidadActual - 1) * precio;
                    selectedRow.Cells["Subtotal"].Value = subtotal;

                    ActualizarTotal(); // Actualizar el total visualmente
                }
                else
                {
                    // Si la cantidad es 1, eliminar la fila
                    dgvConsumo.Rows.Remove(selectedRow);


                    ActualizarTotal(); // Actualizar el total visualmente

                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto del consumo para restar.");
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {

            string metodo = "";
            PagoForm pago = new PagoForm(Convert.ToInt32(totalAPagar - totalPagado));


            pago.ShowDialog();
            if (pago.pagoOk)
            {
                if (pago.metodoPago == 0)
                {
                    totalEfectivo += pago.monto;
                    metodo = "Efectivo";
                    dgvPagos.Rows.Add(metodo, pago.montoPagado.ToString("n0"), pago.monto.ToString("n0"), Convert.ToString(pago.montoPagado - pago.monto));
                }
                else
                {
                    totalTarjeta += pago.monto;
                    metodo = "Tarjeta";
                    dgvPagos.Rows.Add(metodo, "", pago.monto.ToString("n0"));
                }
                totalPagado = totalTarjeta + totalEfectivo;
                lblTotalPagado.Text = "$" + (totalEfectivo + totalTarjeta).ToString("n0");

                lblMontoPendiente.Text = "$" + (totalAPagar - totalPagado).ToString("n0");

            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

            // Mostrar el cuadro de diálogo con los botones Yes y No
            DialogResult resultado = MessageBox.Show("Vas a cerrar la Mesa. ¿Estas seguro?.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (totalPagado == totalAPagar)
            {
                // Evaluar la respuesta del usuario
                if (resultado == DialogResult.Yes)
                {

                    using (var context = new ClubPoolContext())
                    {
                        // Primero, insertamos la venta en la tabla Venta
                        var detalleApertura = context.Detalle_Caja.Where(da => da.Estado).FirstOrDefault();
                        var nuevaVenta = new Venta
                        {
                            Hora = DateTime.Now,
                            Estado = true,  // Asume que la venta está activa
                            Fecha = DateTime.Now,
                            Total = (int)totalAPagar,
                            MontoConsumo = (int)totalAPagar,
                            MontoEfectivo = (int)totalEfectivo,
                            MontoTarjeta = (int)totalTarjeta,// Aquí debes tener calculado el total a pagar previamente
                            Fk_Id_Mesa = 13,  // Aquí deberías colocar el ID de la mesa correspondiente
                            Fk_Id_Caja = 2,  // El ID de la caja activa
                            TipoVenta = 2,  // Aquí podrías ajustar si es efectivo o tarjeta
                            Fk_Id_Detalle_Caja = detalleApertura.Id,
                            Fk_Id_Usuario = userId
                        };

                        context.Venta.Add(nuevaVenta);
                        context.SaveChanges();  // Esto genera el ID de la nueva venta

                        // Ahora insertamos los productos consumidos en la tabla Detalle_Venta
                        foreach (DataGridViewRow row in dgvConsumo.Rows)
                        {

                            int idProducto = Convert.ToInt32(row.Cells["Id2"].Value);
                            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                            // Insertar el detalle de la venta
                            var detalleVenta = new Detalle_Venta
                            {
                                Fk_Id_Venta = nuevaVenta.Id,  // El ID de la venta recién creada
                                Fk_Id_Producto = idProducto,  // El ID del producto
                                Cantidad = cantidad,
                                Fecha = DateTime.Now
                                // La cantidad del producto
                            };

                            context.Detalle_Venta.Add(detalleVenta);

                        }

                        context.SaveChanges();  // Guardar todos los detalles de la venta en la base de datos

                    }


                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Para poder cerrar la venta debe primero cancelar el Total.");
                return;
            }


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower(); // Convertir a minúsculas para búsqueda insensible a mayúsculas

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {

                CargarProductos();
            }
            else
            {

                using (var context = new ClubPoolContext())
                {
                    // Obtener los productos de la base de datos
                    var productos = context.Producto.Where(p => p.Descripcion.ToLower().Contains(textoBusqueda) ||
                                p.Codigo.ToLower().Contains(textoBusqueda)) // Puedes agregar más condiciones aquí si es necesario
                    .ToList();


                    // Asignar los productos al DataGridView
                    dgvProductos.AutoGenerateColumns = false;
                    dgvProductos.DataSource = productos;
                }



            }
        }

        private void VentaForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        void limpiarPagos()
        {
            totalPagado = 0;
            totalEfectivo = 0;
            totalTarjeta = 0;
            lblTotalPagado.Text = "$0";
            lblMontoPendiente.Text = "$0";
            dgvPagos.DataSource = null;
            dgvPagos.Rows.Clear();
        }

        private void btnCancelarPagos_Click(object sender, EventArgs e)
        {
            limpiarPagos();
        }

    }
}
