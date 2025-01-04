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
    public partial class PagoForm : Form
    {

        public int metodoPago = 0;
        public int monto = 0;
        public int montoDeuda = 0;
        public int montoPagado = 0;
        public bool pagoOk = false;
        public int montoEfectivo = 0;

        public PagoForm(int _montoDeuda)
        {
            metodoPago = 0;
            montoDeuda = _montoDeuda;

            InitializeComponent();
            txtMonto.Text = _montoDeuda.ToString("n0");
            lblTotal.Text = _montoDeuda.ToString("n0");

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                monto = Convert.ToInt32(txtMonto.Text.Replace(".", ""));
                bool isTarjeta = rbTarjeta.Checked;
                bool isEfectivo = rbEfectivo.Checked;

                if (monto > montoDeuda)
                {
                    pagoOk = false;
                    string mensaje = isTarjeta ?
                        "El monto pagado con tarjeta no puede superar el total de la cuenta" :
                        "El monto pagado no puede superar el monto total";
                    MessageBox.Show(mensaje);
                }
                else
                {
                    if (isEfectivo)
                    {

                        if (!string.IsNullOrWhiteSpace(txtPagado.Text))
                        {
                            if (Convert.ToInt32(txtPagado.Text.Replace(".", "")) < Convert.ToInt32(txtMonto.Text.Replace(".", "")))
                            {
                                MessageBox.Show("El efectivo pagado debe ser igual al total ingresado");

                                return;
                            }
                            montoPagado = Convert.ToInt32(txtPagado.Text.Replace(".", ""));
                        }
                        else
                        {
                            MessageBox.Show("Ingrese el monto de efectivo pagado");
                            return;
                        }

                    }

                    pagoOk = true;
                    metodoPago = isTarjeta ? 1 : 0;
                }

                if (pagoOk)
                {
                    this.Close();
                }
            }
        }


        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTarjeta.Checked)
            {
                txtMonto.Text = montoDeuda.ToString("n0");
                txtPagado.Enabled = false;
                txtPagado.Visible = false;
                lblEfectivoPagado.Visible = false;
            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                txtPagado.Enabled = true;
                txtPagado.Visible = true;
                lblEfectivoPagado.Visible = true;
            }
        }
        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.SoloNumeros(sender, e);
        }

        private void txtMonto_Leave(object sender, EventArgs e)
        {
            Utils.ValidarYFormatear(txtMonto);
        }

        private void txtPagado_Leave(object sender, EventArgs e)
        {
            Utils.ValidarYFormatear(txtPagado);
        }


        private void Pago_Load(object sender, EventArgs e)
        {

            // Asociar los eventos KeyPress
            txtMonto.KeyPress += Utils.SoloNumeros;
            txtPagado.KeyPress += Utils.SoloNumeros;

        }

        private void txtPagado_TextChanged(object sender, EventArgs e)
        {
            Utils.FormatearMiles(txtPagado);
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            Utils.FormatearMiles(txtMonto);
        }
    }
}
