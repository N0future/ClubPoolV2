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
    public partial class TiempoForm : Form
    {
        public DateTime fechaElegida;
        public int elegida = 1;
        public bool huboEleccion = false;
        public TiempoForm()
        {
            InitializeComponent();
        }

        private void TiempoForm_Load(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (rbPersonalizada.Checked)
            {


                DateTime horaSeleccionada = pickerTiempo.Value;

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Combinar la fecha actual con la hora seleccionada
                fechaElegida = new DateTime(fechaActual.Year, fechaActual.Month, fechaActual.Day,
                                                   horaSeleccionada.Hour, horaSeleccionada.Minute, horaSeleccionada.Second);

                // Validar que la hora seleccionada no sea mayor a la hora actual
                if (fechaElegida > fechaActual)
                {
                    MessageBox.Show("La hora seleccionada no puede ser mayor a la hora actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // No permitir que se cierre el formulario
                }
            }

            this.Close();
        }


        private void rbPersonalizada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersonalizada.Checked)
            {
                elegida = 2;
                groupBox1.Visible = true;
                huboEleccion = true;

            }
        }

        private void rbHoraActual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHoraActual.Checked)
            {

                fechaElegida = DateTime.Now;
                elegida = 1;
                groupBox1.Visible = false;
                huboEleccion = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            huboEleccion = false;
            elegida = 0;
            this.Close();
        }
    }
}
