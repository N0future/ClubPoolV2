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
    public partial class AbrirCajaForm : Form
    {
        public ClubPoolContext context = new ClubPoolContext();

        public AbrirCajaForm(string username)
        {


            InitializeComponent();
            CargarCombo();
            alternarCompontentes();
            ObtenerDataVentasApertura();
            lblCajero.Text = username;
        }

        void CargarCombo()
        {
            using (var context = new ClubPoolContext())
            {
                var cajas = context.Caja.ToList();

                cmbCaja.DataSource = cajas;
                cmbCaja.DisplayMember = "Nombre";
                cmbCaja.ValueMember = "Id";
            }
        }




        void ObtenerDataVentasApertura()
        {
            using (var context = new ClubPoolContext())
            {
                // Obtener el detalle de la caja seleccionada
                var detalleCaja = context.Detalle_Caja
                    .FirstOrDefault(c => c.Fk_Id_Caja == 2 && c.Estado); // Ajustar el Fk_Id_Caja según tu lógica

                if (detalleCaja != null)
                {
                    // Consultar las ventas desde la fecha de apertura hasta el momento actual
                    var ventas = context.Venta.Where(v => v.Fk_Id_Detalle_Caja == detalleCaja.Id).ToList();

                    var cantidadVentas = ventas.Count();

                    // Calcular el total en efectivo, tarjeta y total de ventas
                    decimal totalEfectivo = ventas.Sum(v => v.MontoEfectivo);
                    decimal totalTarjeta = ventas.Sum(v => v.MontoTarjeta);
                    decimal totalVentas = ventas.Sum(v => v.Total);
                    decimal totalVentasMesas = ventas.Sum(v => v.MontoMesas);
                    decimal totalEnConsumo = ventas.Sum(v => v.MontoConsumo);

                    // Actualizar los labels}
                    lblCantidadVentas.Text = cantidadVentas.ToString("n0");
                    lblMontoEfectivo.Text = totalEfectivo.ToString("n0");
                    lblMontoTarjeta.Text = totalTarjeta.ToString("n0");
                    lblTotalVentas.Text = totalVentas.ToString("n0");
                    lblGananciasMesas.Text = totalVentasMesas.ToString("n0");
                    lblTotalConsumo.Text = totalEnConsumo.ToString("n0");

                }
                else
                {
                    MessageBox.Show("No se encontró un detalle de caja abierto.");
                }
            }
        }

        void alternarCompontentes()
        {

            using (var context = new ClubPoolContext())
            {
                var caja = context.Caja.ToList().FirstOrDefault();
                var detalle = context.Detalle_Caja.ToList().Where(c => c.Fk_Id_Caja == 2 && c.Estado).FirstOrDefault();

                if (caja.Estado)
                {
                    txtMontoInicio.Enabled = false;

                    txtMontoInicio.Text = detalle.MontoInicio.ToString("n0");
                    btnAbrirCaja.Enabled = false;
                    btnCerrarCaja.Enabled = true;
                    txtMontoCierre.Enabled = true;
                    lblEstadoCaja.Text = "Caja Abierta";
                    btnAbrirCaja.Visible = false;
                    btnCerrarCaja.Visible = true;
                    lblMontoCierre.Visible = true;
                }
                else
                {
                    lblEstadoCaja.Text = "Caja Cerrada";
                    btnAbrirCaja.Visible = true;
                    btnCerrarCaja.Visible = false;
                    txtMontoCierre.Visible = false;
                    btnAbrirCaja.Enabled = true;
                    btnCerrarCaja.Enabled = false;
                    lblMontoCierre.Visible = false;
                }

            }
        }


        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {

            if (txtMontoCierre.Text == "" || txtMontoCierre.Text == null)
            {
                MessageBox.Show("Debe introducir un monto final para poder completar el cierre");
                return;
            }
            // Obtener el ID de la caja seleccionada en el combo box
            int IdCaja = Convert.ToInt32(cmbCaja.SelectedValue);

            // Buscar el registro de la caja activa
            var caja = context.Caja.SingleOrDefault(c => c.Id == IdCaja && c.Estado == true);
            if (caja != null)
            {
                // Buscar el Detalle_Caja asociado a esta caja que esté activo
                var detalleCaja = context.Detalle_Caja
                    .SingleOrDefault(dc => dc.Fk_Id_Caja == caja.Id && dc.Estado); // Cierre no realizado

                if (detalleCaja != null)
                {
                    // Cerrar el detalle de la caja
                    detalleCaja.Fecha_Cierre = DateTime.Now; // Fecha de cierre
                    detalleCaja.Estado = false; // Cambiar el estado del detalle a cerrado
                    detalleCaja.MontoFinal = Convert.ToInt32(txtMontoCierre.Text.Replace(".", ""));
                    // Cambiar el estado de la caja
                    caja.Estado = false;

                    // Guardar los cambios
                    context.SaveChanges();

                    MessageBox.Show("Caja cerrada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró un detalle de caja activo para cerrar.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró una caja activa para cerrar.");
            }

            this.Close();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {

            // Validar que el monto de inicio no esté vacío y sea un número válido
            if (string.IsNullOrEmpty(txtMontoInicio.Text) || !decimal.TryParse(txtMontoInicio.Text, out decimal montoInicio) || montoInicio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un monto de inicio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Evitar que el código continúe si el monto es inválido
            }
            using (var context = new ClubPoolContext())
            {
                // Obtener el ID de la caja seleccionada en el combo box
                int IdCaja = Convert.ToInt32(cmbCaja.SelectedValue);

                // Buscar si la caja ya está abierta
                var caja = context.Caja.SingleOrDefault(c => c.Id == IdCaja && c.Estado == false);
                if (caja != null)
                {
                    // Asegurarse de que no exista un detalle de caja abierto
                    var detalleCajaAbierta = context.Detalle_Caja
                        .SingleOrDefault(dc => dc.Fk_Id_Caja == IdCaja && dc.Fecha_Cierre == null);

                    if (detalleCajaAbierta == null)
                    {
                        // Crear un nuevo registro en la tabla Detalle_Caja
                        var nuevoDetalleCaja = new Detalle_Caja
                        {
                            MontoInicio = Convert.ToInt32(txtMontoInicio.Text.Replace(".", "")), // Asignar el monto inicial desde el textbox
                            MontoFinal = 0, // Inicializar con 0 (se calculará al cerrar)
                            Fecha_Apertura = DateTime.Now, // Establecer la fecha de apertura actual
                            Fk_Id_Caja = IdCaja, // Asignar el ID de la caja seleccionada
                            Fk_Id_Usuario = 1, // Asignar el ID del usuario (ajustar según la lógica de tu sistema)
                            Estado = true // Estado abierto
                        };

                        // Cambiar el estado de la caja a abierta
                        caja.Estado = true;

                        // Agregar el nuevo detalle de caja a la base de datos
                        context.Detalle_Caja.Add(nuevoDetalleCaja);

                        // Guardar los cambios
                        context.SaveChanges();

                        MessageBox.Show("Caja abierta correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("La caja ya está abierta.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la caja o ya está abierta.");
                }

                this.Close();
            }
        }

        private void AbrirCajaForm_Load(object sender, EventArgs e)
        {
            txtMontoCierre.KeyPress += Utils.SoloNumeros;
            txtMontoInicio.KeyPress += Utils.SoloNumeros;
        }

        private void txtMontoCierre_TextChanged(object sender, EventArgs e)
        {
            // Verificar que el monto de cierre sea un número válido
            if (decimal.TryParse(txtMontoCierre.Text, out decimal montoCierre))
            {
                // Obtener el efectivo inicial (de tu control txtEfectivoInicial)
                decimal efectivoInicial = 0;
                if (decimal.TryParse(txtMontoInicio.Text, out decimal montoInicial))
                {
                    efectivoInicial = montoInicial;
                }

                var a = lblMontoEfectivo.Text;
                // Obtener las ventas en efectivo (de tu control lblVentasEfectivo)
                decimal totalVentasEfectivo = 0;
                if (decimal.TryParse(lblMontoEfectivo.Text, out decimal ventasEfectivo))
                {
                    totalVentasEfectivo = ventasEfectivo;
                }

                // Calcular el efectivo esperado (Efectivo Inicial + Ventas en Efectivo)
                decimal efectivoEsperado = efectivoInicial + totalVentasEfectivo;

                // Calcular la diferencia entre el monto de cierre y el efectivo esperado
                decimal diferencia = montoCierre - efectivoEsperado;

                // Mostrar la diferencia en el lblDiferencia
                if (diferencia < 0)
                {
                    lblDiferencia.ForeColor = Color.Red;
                }
                else
                {
                    lblDiferencia.ForeColor = Color.Green;
                }
                lblDiferencia.Text = diferencia.ToString("n0");
            }
            else
            {
                // Si el texto no es un número válido, se limpia el lblDiferencia
                lblDiferencia.Text = "0";
            }
            Utils.FormatearMiles(txtMontoCierre);
        }

        private void btnDetallesAperturas_Click(object sender, EventArgs e)
        {
            DetalleAperturaCierreForm detalleAperturaCierreForm = new DetalleAperturaCierreForm();
            detalleAperturaCierreForm.ShowDialog();
        }

        private void txtMontoInicio_TextChanged(object sender, EventArgs e)
        {
            Utils.FormatearMiles(txtMontoInicio);
        }

        private void AbrirCajaForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));

        }
    }
}

