using Billar.Context;
using Billar.Models;
using System.Data.Entity;

namespace Billar
{
    public partial class MainForm : Form
    {

        public ClubPoolContext context = new ClubPoolContext();
        private Dictionary<int, DateTime> horaInicioMesas = new Dictionary<int, DateTime>(); // Guardar la hora de inicio para cada mesa
        public int IdMesa;
        public int userId;
        public string userName;

        public MainForm(int _userId, string _username)
        {

            userId = _userId;
            InitializeComponent();
            CargarInformacionMesas();
            IniciarTimers();
            IniciarTotalTimer(); // Iniciar el tim
            ActualizarTotales();
            ActualizarLabelEstadoCaja();
            lblUsuario.Text = _username;
            userName = _username;
            panelMain.BackColor = Color.Transparent;

        }


        bool ActualizarLabelEstadoCaja()
        {
            using (var context = new ClubPoolContext())
            {
                var caja = context.Caja.SingleOrDefault(c => c.Id == 2);

                if (caja.Estado)
                {
                    lblEstadoCaja.Text = "Caja Abierta";
                    lblEstadoCaja.ForeColor = Color.Green;
                    return true;
                }
                else
                {
                    lblEstadoCaja.Text = "Caja  Cerrada";
                    lblEstadoCaja.ForeColor = Color.Red;

                    return false;
                }
            }


        }

        void EstablecerDatosDeUsuario()
        {

        }
        void IniciarTimers()
        {
            time1.Start();
            time2.Start();
            time3.Start();
            time4.Start();
            time5.Start();
            time6.Start();
            time7.Start();
            time8.Start();
            time9.Start();
            time10.Start();
            time11.Start();
            time12.Start();
        }
        void IniciarTotalTimer()
        {
            totalTimer = new System.Windows.Forms.Timer();
            totalTimer.Interval = 60000; // 1 minuto (60,000 milisegundos)

            totalTimer.Start(); // Iniciar el temporizador
        }
        void ActualizarTotales()
        {
            using (var newContext = new ClubPoolContext())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var ventaActiva = newContext.Venta
                        .AsNoTracking()
                        .Where(v => v.Fk_Id_Mesa == i && v.Estado == true)
                        .FirstOrDefault();

                    if (ventaActiva != null)
                    {
                        // Sumar los subtotales de los detalles de venta
                        var total = newContext.Detalle_Venta
                            .Where(dv => dv.Fk_Id_Venta == ventaActiva.Id)
                            .Sum(dv => (decimal?)dv.Cantidad * dv.Producto.Precio) ?? 0;

                        // Actualizar el label correspondiente
                        string labelTotalName = $"lblTotal{i}";
                        var labelTotal = this.Controls.Find(labelTotalName, true).FirstOrDefault() as Label;
                        if (labelTotal != null)
                        {
                            labelTotal.Text = $"${total:n0}";
                        }
                    }
                }
            }
        }
        void CargarInformacionMesas()
        {
            using (var newContext = new ClubPoolContext())
            {
                var listMesas = newContext.Mesa.AsNoTracking().ToList(); // Asegura que los datos no estén en caché.

                foreach (var mesa in listMesas)
                {
                    // Obtener la venta activa (si la mesa está ocupada)
                    var ventaActiva = newContext.Venta
                        .AsNoTracking()
                        .Where(v => v.Fk_Id_Mesa == mesa.Id && v.Estado == true)
                        .FirstOrDefault();

                    // Si hay una venta activa, obtener la hora de inicio
                    if (ventaActiva != null && mesa.Estado == 1)
                    {
                        horaInicioMesas[mesa.Id] = (DateTime)ventaActiva.Hora;
                    }

                    string labelName = $"lblEstado{mesa.Id}";
                    string btnName = $"btnMesa{mesa.Id}";
                    var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                    var button = this.Controls.Find(btnName, true).FirstOrDefault() as Button;
                    if (label != null) // Si el label existe
                    {
                        if (mesa.Estado == 1)
                        {
                            label.Text = "(Ocupada)";
                            label.ForeColor = Color.Red;
                            button.FlatAppearance.BorderColor = Color.Red;
                        }
                        else
                        {
                            label.Text = "(Libre)";
                            label.ForeColor = Color.Green;
                            button.FlatAppearance.BorderColor = Color.Green;
                        }
                    }
                }
            }
        }
        void DetenerContador(int mesaId, string labelName)
        {
            // Remover la hora de inicio de la mesa si existe
            if (horaInicioMesas.ContainsKey(mesaId))
            {
                horaInicioMesas.Remove(mesaId);

                // Detener el Timer correspondiente
                switch (mesaId)
                {
                    case 1: time1.Stop(); break;
                    case 2: time2.Stop(); break;
                    case 3: time3.Stop(); break;
                    case 4: time4.Stop(); break;
                    case 5: time5.Stop(); break;
                    case 6: time6.Stop(); break;
                    case 7: time7.Stop(); break;
                    case 8: time8.Stop(); break;
                    case 9: time9.Stop(); break;
                    case 10: time10.Stop(); break;
                    case 11: time11.Stop(); break;
                    case 12: time12.Stop(); break;
                }

                // Actualizar el label correspondiente a la mesa
                var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = "00:00:00"; // Reiniciar el texto del label

                }
            }
        }
        void ReiniciarContador(int mesaId, DateTime horaInicio)
        {
            // Guardar la nueva hora de inicio
            horaInicioMesas[mesaId] = horaInicio;

            // Reiniciar el Timer correspondiente
            switch (mesaId)
            {
                case 1: time1.Start(); break;
                case 2: time2.Start(); break;
                case 3: time3.Start(); break;
                case 4: time4.Start(); break;
                case 5: time5.Start(); break;
                case 6: time6.Start(); break;
                case 7: time7.Start(); break;
                case 8: time8.Start(); break;
                case 9: time9.Start(); break;
                case 10: time10.Start(); break;
                case 11: time11.Start(); break;
                case 12: time12.Start(); break;
            }
        }
        void AbrirDetalleMesa(object sender, EventArgs e)
        {

            if (ActualizarLabelEstadoCaja())
            {
                Button mesa = sender as Button;
                int mesaId = Convert.ToInt32(mesa.Tag);
                MesaDetalleForm mesaDetalle = new MesaDetalleForm(mesaId, userId);

                mesaDetalle.FormClosing += (s, args) =>
                {
                    if (mesaDetalle.Mesa.Estado == 0) // Si la mesa fue cerrada
                    {
                        string labelName = $"lblTimer{mesaId}";
                        var label = this.Controls.Find($"lblTotal{mesaId}", true).FirstOrDefault() as Label;
                        label.Text = "$0";
                        DetenerContador(mesaId, labelName); // Detener el contador de la mesa cerrada
                    }
                    else if (mesaDetalle.Mesa.Estado == 1) // Si la mesa fue reabierta
                    {
                        ReiniciarContador(mesaId, DateTime.Now); // Registrar la nueva hora
                    }

                    ActualizarTotales(); // Actualizar los totales al cerrar el formulario
                    CargarInformacionMesas(); // Recargar la información de las mesas
                };

                mesaDetalle.ShowDialog();

            }
            else
            {
                MessageBox.Show("Para seguir operando el sistema debe realizar una apertura de Caja");
            }


        }
        void EstablecerLabelTimer(int mesaId, string labelName)
        {
            // Obtener la hora de inicio de la mesa desde el diccionario
            if (horaInicioMesas.ContainsKey(mesaId))
            {
                DateTime horaInicio = horaInicioMesas[mesaId];
                TimeSpan tiempoTranscurrido = DateTime.Now - horaInicio;

                // Actualizar el label correspondiente
                var label = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",
                        tiempoTranscurrido.Hours, tiempoTranscurrido.Minutes, tiempoTranscurrido.Seconds);
                }
            }
        }
        #region EventosBotonMesa
        private void btnMesa1_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa2_Click_1(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            AbrirDetalleMesa(sender, e);
        }
        #endregion
        #region EventosTick
        // Evento Tick de los timers, cada uno con la mesa correspondiente
        private void time1_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(1, "lblTimer1");
        }

        private void time2_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(2, "lblTimer2");
        }

        private void time3_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(3, "lblTimer3");
        }

        private void time4_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(4, "lblTimer4");
        }

        private void time5_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(5, "lblTimer5");
        }

        private void time6_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(6, "lblTimer6");
        }

        private void time7_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(7, "lblTimer7");
        }

        private void time8_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(8, "lblTimer8");
        }

        private void time9_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(9, "lblTimer9");
        }

        private void time10_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(10, "lblTimer10");
        }

        private void totalTimer_Tick(object sender, EventArgs e)
        {
            ActualizarTotales();
        }

        private void time11_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(11, "lblTimer11");
        }

        private void time12_Tick(object sender, EventArgs e)
        {
            EstablecerLabelTimer(12, "lblTimer12");
        }
        #endregion



        private void btnReporteVenta_Click(object sender, EventArgs e)
        {
            AbrirCajaForm abrirCaja = new AbrirCajaForm(userName);
            abrirCaja.ShowDialog();
            ActualizarLabelEstadoCaja();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            MesasForm mesasForm = new MesasForm();
            mesasForm.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

            if (ActualizarLabelEstadoCaja())
            {


                VentaForm venta = new VentaForm(userId);
                venta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Para seguir operando el sistema debe realizar una apertura de Caja");
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReporteVentasForm reporteVentasForm = new ReporteVentasForm();
            reporteVentasForm.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosForm productos = new ProductosForm();
            productos.ShowDialog();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Utils.SetBackground(this, e, Color.Black, Color.FromArgb(57, 128, 227));
        }

        private void lblEstado3_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }



}