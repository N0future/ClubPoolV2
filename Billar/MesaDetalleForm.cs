using Billar.Context;
using Billar.Models;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Billar.MainForm;
using Color = System.Drawing.Color;

namespace Billar
{

    public partial class MesaDetalleForm : Form
    {
        public ClubPoolContext context = new ClubPoolContext();
        private System.Windows.Forms.Timer timer;
        public int idMesa { get; set; }
        public Mesa Mesa = new Mesa();
        private Venta ventaActual; // Variable para almacenar la venta actual
        private DateTime horaInicio; // Guardar la hora de inicio (Venta.Hora)
        private int totalEfectivo = 0;
        private int totalTarjeta = 0;
        private int totalPagado = 0;
        private decimal totalAPagarAjustado = 0;
        private decimal totalMesaAjustado = 0;
        private decimal totalPorTiempo = 0;
        private int totalAPagar = 0;
        public bool pagoOk = false;
        public bool seCalculoPago = false;
        public TimeSpan tiempoCalculoHora;
        public bool tiempoDetenido;
        private TimeSpan tiempoAcumulado = TimeSpan.Zero; // Almacena el tiempo transcurrido antes de parar
        private int IdApertura;
        private int userId;
        // Ruta relativa dentro del proyecto
    
  
        public MesaDetalleForm(int _IdMesa, int userId)
        {
            InitializeComponent();
            idMesa = _IdMesa;

            CargarDataMesa();
            CargarProductos();
            CargarDetallesConsumo(); // Llamada para cargar los detalles de consumo
            EstablecerLabels();
            EstablecerBotonMesa();
            // Llamar al método para iniciar el tiempo transcurrido

            dgvPagos.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.userId = userId;
        }

        public void CargarDataMesa()
        {
            Mesa = context.Mesa.ToList().Where(m => m.Id == idMesa).Single();
            var detalleApertura = context.Detalle_Caja.Where(da => da.Estado).FirstOrDefault();
            IdApertura = detalleApertura.Id;
            if (Mesa.Estado != 0)
            {
                ventaActual = context.Venta.ToList().Where(v => v.Fk_Id_Mesa == Mesa.Id && v.Estado).Single();
                horaInicio = (DateTime)ventaActual.Hora;
                IniciarTiempoTranscurrido(horaInicio);
                if (ventaActual.Hora.HasValue)
                {
                    lblHoraLlegada.Text = ventaActual.Hora.Value.ToString("HH:mm:ss");
                }
            }
            else
            {
                lblHoraLlegada.Text = "-"; // O cualquier mensaje por defecto si el valor es nulo
                lblTiempoTranscurrido.Text = "-";
            }

        }

        private void CargarProductos()
        {
            using (var context = new ClubPoolContext())
            {
                // Obtener los productos de la base de datos
                var productos = context.Producto.Where(p => p.Estado == true).ToList();


                // Asignar los productos al DataGridView
                dgvProductos.AutoGenerateColumns = false;
                dgvProductos.DataSource = productos;
            }


        }


        void EstablecerBotonMesa()
        {
            if (Mesa.Estado == 1)
            {
                btnPararTiempo.Image = Properties.Resources.pause;
                btnPararTiempo.Visible = true;
                btnEstadoMesa.Visible = false;
                btnEstadoMesa.BackColor = System.Drawing.Color.Red;
                btnEstadoMesa.Text = "Cerrar  mesa ";
            }
            else
            {
                btnPararTiempo.Image = Properties.Resources.play;
                btnPararTiempo.Visible = false;
                btnEstadoMesa.BackColor = Color.Green;
                btnEstadoMesa.Text = "Abrir Mesa";
            }

        }

        void EstablecerLabels()
        {

            lblIdMesa.Text = idMesa.ToString();
            //lblTiempo.Text = Mesa.Tiempo.ToString();

            if (Mesa.Estado == 1)
            {

                lblEstado.Text = "Mesa Ocupada";
                lblEstado.ForeColor = Color.Red;
            }
            else
            {
                lblEstado.Text = "Mesa Libre";
                lblEstado.ForeColor = Color.GreenYellow;
            }

            lblValorMesa.Text = "$" + Mesa.Precio.ToString();


        }

        public void CargarDetallesConsumo()
        {
            if (Mesa.Estado == 1) // Si la mesa está ocupada
            {
                if (ventaActual != null)
                {
                    // Limpiar el DataGridView antes de agregar nuevos datos
                    dgvConsumo.Rows.Clear();

                    // Obtener los detalles de venta agrupados por producto y sumar las cantidades
                    var detalleVentas = context.Detalle_Venta
                        .Where(dv => dv.Fk_Id_Venta == ventaActual.Id)
                        .GroupBy(dv => dv.Fk_Id_Producto)
                        .Select(grupo => new
                        {
                            Fk_Id_Producto = grupo.Key,
                            CantidadTotal = grupo.Sum(dv => dv.Cantidad)
                        }).ToList();

                    // Recorrer los detalles de la venta agrupados
                    foreach (var detalle in detalleVentas)
                    {
                        // Obtener los datos del producto para el detalle
                        var producto = context.Producto.Find(detalle.Fk_Id_Producto);
                        if (producto != null)
                        {
                            // Agregar una fila al dgvConsumo con la cantidad total agrupada
                            dgvConsumo.Rows.Add(detalle.Fk_Id_Producto, producto.Descripcion, producto.Precio, detalle.CantidadTotal, (detalle.CantidadTotal * producto.Precio));
                        }
                    }

                    // Actualizar el total visual
                    ActualizarTotal();
                }
            }
            else
            {
                // Si la mesa está libre, limpiar el DataGridView
                dgvConsumo.Rows.Clear();
                lblTotalConsumido.Text = "0";
                lblTotal.Text = "0";
            }
        }

        private void btnEstadoMesa_Click_1(object sender, EventArgs e)
        {


            if (Mesa.Estado == 0)
            {
                TiempoForm tiempoForm = new TiempoForm();
                tiempoForm.ShowDialog();


                DateTime tiempo = new DateTime();
                if (tiempoForm.elegida == 1)
                {
                    tiempo = DateTime.Now;
                }
                else
                {


                    tiempo = tiempoForm.fechaElegida;
                }



                if (tiempoForm.huboEleccion)
                {


                    var nuevaVenta = new Venta
                    {
                        Hora = tiempo,
                        Estado = true,
                        Fecha = DateTime.Now,
                        Total = 0,
                        Fk_Id_Mesa = Mesa.Id,
                        Fk_Id_Caja = 2, //Cuidado
                        TipoVenta = 1,
                        Fk_Id_Usuario = userId



                    };

                    context.Venta.Add(nuevaVenta);
                    context.SaveChanges();
                    Mesa.Estado = 1;
                    ventaActual = nuevaVenta;
                    horaInicio = (DateTime)nuevaVenta.Hora;
                    IniciarTiempoTranscurrido(horaInicio);
                    if (ventaActual.Hora.HasValue)
                    {
                        lblHoraLlegada.Text = ventaActual.Hora.Value.ToString("HH:mm:ss");
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir la hora de inicio para abrir la mesa");
                    return;
                }
            }
            else if (Mesa.Estado == 1)
            {


                void cerrarMesa()
                {
                    // Cambiar el estado de la mesa
                    Mesa.Estado = 0;
                    Mesa.Tiempo = null;
                    var montoMesas = Convert.ToInt32(lblTotalMesa.Text.Replace(".", "").Replace("$", ""));
                    // Buscar la venta activa
                    var ventaActiva = context.Venta
                        .Where(v => v.Fk_Id_Mesa == Mesa.Id && v.Estado == true)
                        .SingleOrDefault();

                    if (ventaActiva != null)
                    {
                        // Actualizar los montos en la venta activa
                        var montoMesaAjustado = (int)(Math.Round(montoMesas / 10.0) * 10);
                        ventaActiva.Estado = false; // Marcar la venta como cerrada
                        ventaActiva.MontoEfectivo = totalEfectivo; // Asignar el monto en efectivo
                        ventaActiva.MontoTarjeta = totalTarjeta;   // Asignar el monto en tarjeta
                        ventaActiva.Total = Convert.ToInt32(totalAPagarAjustado); // Puedes actualizar el total con la variable que desees
                        ventaActiva.Fk_Id_Detalle_Caja = IdApertura;
                        ventaActiva.MontoMesas = montoMesaAjustado;
                        ventaActiva.MontoConsumo = Convert.ToInt32(totalAPagarAjustado - montoMesaAjustado);
                        ventaActiva.Fecha = DateTime.Now;
                        // Guardar los cambios en la base de datos
                        context.SaveChanges();
                    }

                    // Detener el timer y cerrar la ventana
                    timer.Stop();
                    ventaActual = null;
                    this.Close();
                }
                // Mostrar el cuadro de diálogo con los botones Yes y No
                DialogResult resultado = MessageBox.Show("Vas a cerrar la Mesa. ¿Estas seguro?.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultado == DialogResult.Yes)
                {
                    if (totalPagado == totalAPagarAjustado)
                    {
                        cerrarMesa();


                    }
                    else
                    {
                        DialogResult resultado2 = MessageBox.Show("El monto pagado no es igual al monto por cancelar por lo que se le va a generar un descuadre, ¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (resultado2 == DialogResult.Yes)
                        {
                            cerrarMesa();
                        }
                    }

                }
                else
                {
                    return;
                }






            }

            // Guardar los cambios en la base de datos
            context.SaveChanges();

            // Actualizar la UI
            EstablecerLabels();
            EstablecerBotonMesa();
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
            totalAPagar = (int)(totalConsumido + totalPorTiempo);
            // Actualizar los labels con el total consumido y el total de tiempo de la mesa
            lblTotalConsumido.Text = "$" + totalConsumido.ToString("n0"); // Productos consumidos
            lblTotal.Text = "$" + (totalConsumido + totalPorTiempo).ToString("n0"); // Total consumido de productos

            if (!seCalculoPago)
            {
                btnPararTiempo.Enabled = true;
                seCalculoPago = true;
            }

        }
        private void IniciarTiempoTranscurrido(DateTime horaVenta)
        {
            // Guardar la hora de inicio
            horaInicio = horaVenta;

            // Inicializar el Timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += timer1_Tick; // Asignar el evento que se ejecuta cada segundo
            timer.Start(); // Iniciar el Timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!tiempoDetenido)
            {
                // Calcular el tiempo transcurrido desde la hora de inicio más el tiempo acumulado
                TimeSpan tiempoTranscurrido = (DateTime.Now - horaInicio) + tiempoAcumulado;

                // Formatear el tiempo transcurrido en horas, minutos y segundos

                if (tiempoTranscurrido.TotalDays > 0) {
                    lblTiempoTranscurrido.Text = ""+tiempoTranscurrido.Days+" Dia - "  + string.Format("{0:D2}:{1:D2}:{2:D2}",
                                     tiempoTranscurrido.Hours, tiempoTranscurrido.Minutes, tiempoTranscurrido.Seconds);
                }
                else
                {
                    lblTiempoTranscurrido.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                      tiempoTranscurrido.Hours, tiempoTranscurrido.Minutes, tiempoTranscurrido.Seconds);
                }
              

                tiempoCalculoHora = tiempoTranscurrido; // Almacenar el tiempo calculado

                // Si han pasado menos de 30 minutos, cobrar el precio mínimo
                if (tiempoTranscurrido.TotalMinutes <= 30)
                {
                    totalPorTiempo = Mesa.PrecioMin;
                }
                else
                {
                    // Si han pasado más de 30 minutos, cobrar el precio mínimo y sumar el proporcional por el tiempo adicional
                    decimal horasTranscurridas = (decimal)(tiempoTranscurrido.TotalMinutes - 30) / 60; // Restar los primeros 30 minutos
                    totalPorTiempo = Mesa.PrecioMin + (horasTranscurridas * Mesa.Precio);
                }

                // Actualizar el label con el total calculado
                lblTotalMesa.Text = "$" + totalPorTiempo.ToString("n0");

                // Actualizar otros valores si es necesario
                ActualizarTotal();
            }
        }





        private void btnSumarItem_Click(object sender, EventArgs e)
        {
            if (Mesa.Estado == 1)
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
                            // Si ya existe, incrementar la cantidad en el DataGridView
                            int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                            row.Cells["Cantidad"].Value = cantidadActual + 1;

                            // Actualizar el subtotal
                            decimal subtotal = Convert.ToInt32(row.Cells["Cantidad"].Value) * precio;
                            row.Cells["Subtotal"].Value = subtotal.ToString("n0");

                            // Crear un nuevo registro en Detalle_Venta con la nueva cantidad y fecha
                            var nuevoDetalle = new Detalle_Venta
                            {
                                Fk_Id_Venta = ventaActual.Id, // Relacionar con la mesa/venta actual
                                Fk_Id_Producto = Convert.ToInt32(Id),
                                Cantidad = 1, // Siempre es 1 porque estamos registrando una nueva adición
                                Fecha = DateTime.Now // Registrar la nueva fecha
                            };

                            // Insertar el nuevo registro en la base de datos
                            context.Detalle_Venta.Add(nuevoDetalle);
                            context.SaveChanges(); // Guardar los cambios

                            ActualizarTotal(); // Actualizar el total visualmente
                            LimpiarPagos();

                            return; // Salir de la función, ya que el producto fue encontrado y actualizado en el DataGridView
                        }
                    }

                    // Si el producto no existe, añadirlo al dgvConsumo con cantidad 1 y precio
                    dgvConsumo.Rows.Add(Id, descripcion, precio, 1, precio.ToString("n0"));

                    // Crear un nuevo registro en Detalle_Venta
                    var nuevoProducto = new Detalle_Venta
                    {
                        Fk_Id_Venta = ventaActual.Id, // Relacionar con la mesa/venta actual
                        Fk_Id_Producto = Convert.ToInt32(Id),
                        Cantidad = 1, // Nueva adición siempre es 1
                        Fecha = DateTime.Now // Registrar la fecha
                    };

                    // Insertar el nuevo registro en la base de datos
                    context.Detalle_Venta.Add(nuevoProducto);
                    context.SaveChanges(); // Guardar los cambios

                    // Actualizar el total visualmente
                    ActualizarTotal();
                    LimpiarPagos();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un producto para agregar.");
                }
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
            if (Mesa.Estado == 1) // Verifica si la mesa está ocupada
            {
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
                        selectedRow.Cells["Subtotal"].Value = subtotal.ToString("n0");

                        // Buscar el registro más reciente en Detalle_Venta para este producto y venta
                        var detalleReciente = context.Detalle_Venta
                            .Where(d => d.Fk_Id_Venta == ventaActual.Id && d.Fk_Id_Producto == Convert.ToInt32(Id))
                            .OrderByDescending(d => d.Fecha) // Ordenar por fecha para obtener el más reciente
                            .FirstOrDefault();

                        if (detalleReciente != null)
                        {
                            // Eliminar el registro más reciente de la base de datos
                            context.Detalle_Venta.Remove(detalleReciente);
                            context.SaveChanges(); // Guardar cambios en la base de datos
                        }

                        ActualizarTotal(); // Actualizar el total visualmente
                    }
                    else
                    {
                        // Si la cantidad es 1, eliminar la fila
                        dgvConsumo.Rows.Remove(selectedRow);

                        // Eliminar todos los registros de Detalle_Venta para este producto y venta
                        var detallesEliminar = context.Detalle_Venta
                            .Where(d => d.Fk_Id_Venta == ventaActual.Id && d.Fk_Id_Producto == Convert.ToInt32(Id))
                            .ToList();

                        if (detallesEliminar.Any())
                        {
                            // Eliminar todos los registros de Detalle_Venta relacionados con este producto
                            context.Detalle_Venta.RemoveRange(detallesEliminar);
                            context.SaveChanges(); // Guardar cambios en la base de datos
                        }

                        ActualizarTotal(); // Actualizar el total visualmente
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un producto del consumo para restar.");
                }
            }
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (lblTotalMesa.Text == "0")
            {
                return;
            }
            string metodo = "";
            PagoForm pago = new PagoForm(Convert.ToInt32(totalAPagarAjustado) - totalPagado);


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

                lblMontoPendiente.Text = "$" + (totalAPagarAjustado - totalPagado).ToString("n0");

            }

        }

        private void btnPararTiempo_Click(object sender, EventArgs e)
        {


            if (tiempoDetenido)
            {
                // Si el tiempo está detenido, reinicia el tiempo y cambia la imagen
                btnPagar.Visible = false;
                LimpiarPagos();
                tiempoDetenido = false;
                btnEstadoMesa.Visible = false;
                horaInicio = DateTime.Now;

                // Cambia la imagen del botón a "arrow-right.png"
                btnPararTiempo.Image = Properties.Resources.pause;
            }
            else
            {
                // Si el tiempo está corriendo, detén el tiempo y cambia la imagen
                totalAPagarAjustado = (decimal)(Math.Round(totalAPagar / 10.0) * 10);
                btnPagar.Visible = true;
                btnEstadoMesa.Visible = true;
                tiempoAcumulado += DateTime.Now - horaInicio;
                tiempoDetenido = true;

                // Cambia la imagen del botón a "arrow-left.png"
                btnPararTiempo.Image = Properties.Resources.play;
            }
        }



        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void MesaDetalleForm_Load(object sender, EventArgs e)
        {

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

        private void btnCancelarPagos_Click(object sender, EventArgs e)
        {
            totalPagado = 0;
            totalTarjeta = 0;
            totalEfectivo = 0;
            lblTotalPagado.Text = "0";
            dgvPagos.DataSource = null;
            dgvPagos.Rows.Clear();
            lblMontoPendiente.Text = "0";
        }

        private void MesaDetalleForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));
        }
    }

}
